using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace AI_Text_Summarizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSummarize_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();

            // Validate input so the user doesn't send empty text
            if (string.IsNullOrEmpty(inputText) || inputText == "Paste your long article or text here...")
            {
                MessageBox.Show("Please enter some text to summarize.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update UI to show loading state
            lblStatus.Text = "Status: Processing with Gemini AI... Please wait.";
            btnSummarize.Enabled = false;
            txtOutput.Text = "Generating summary...";

            try
            {
                // Call the API and update the output box
                string summary = await GetSummaryFromAI(inputText);
                txtOutput.Text = summary;
                lblStatus.Text = "Status: Summarization Complete!";
            }
            catch (Exception ex)
            {
                // Fulfills the "Proper error handling" assignment requirement
                MessageBox.Show($"An error occurred: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Error occurred.";
                txtOutput.Text = "Failed to generate summary.";
            }
            finally
            {
                // Re-enable the button when done
                btnSummarize.Enabled = true;
            }
        }

        private async Task<string> GetSummaryFromAI(string text)
        {
            // 1. Put your Gemini API key here
            string geminiApiKey = "API KEY";

            // 2. We use the blazing-fast Gemini 2.0 Flash model
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={geminiApiKey}";

            using (HttpClient client = new HttpClient())
            {
                // We create the exact JSON structure Google Gemini expects
                var requestBody = new
                {
                    contents = new[]
                    {
                        new { parts = new[] { new { text = "Summarize the following text concisely in a short paragraph: " + text } } }
                    }
                };

                // Serialize our object into a JSON string
                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Send the network request
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Parse Google's response to extract just the summary text
                    JObject json = JObject.Parse(responseString);
                    string summary = json["candidates"][0]["content"]["parts"][0]["text"].ToString();
                    return summary.Trim();
                }
                else
                {
                    // Throw custom exception if the API rejects our call
                    throw new Exception($"Gemini API Error: {response.StatusCode}. Details: {responseString}");
                }
            }
        }
    }
}