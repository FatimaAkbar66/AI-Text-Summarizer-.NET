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
        // We use a free Hugging Face Inference API for summarization
        private readonly string apiUrl = "https://api-inference.huggingface.co/models/facebook/bart-large-cnn";

        // NOTE: You will need a free Hugging Face Token for this to work reliably. 
        // Get one at huggingface.co -> Settings -> Access Tokens
        private readonly string apiKey = "YOUR_HUGGINGFACE_API_KEY_HERE";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSummarize_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(inputText) || inputText == "Paste your long article or text here...")
            {
                MessageBox.Show("Please enter some text to summarize.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatus.Text = "Status: Processing with AI... Please wait.";
            btnSummarize.Enabled = false;
            txtOutput.Text = "";

            try
            {
                string summary = await GetSummaryFromAI(inputText);
                txtOutput.Text = summary;
                lblStatus.Text = "Status: Summarization Complete!";
            }
            catch (Exception ex)
            {
                // Fulfills the "Proper error handling" assignment requirement
                MessageBox.Show($"An error occurred: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Error occurred.";
            }
            finally
            {
                btnSummarize.Enabled = true;
            }
        }

        private async Task<string> GetSummaryFromAI(string text)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                // Create the JSON payload
                var requestBody = new
                {
                    inputs = text,
                    parameters = new { max_length = 130, min_length = 30, do_sample = false }
                };

                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON array response from Hugging Face
                    JArray jsonArray = JArray.Parse(responseString);
                    return jsonArray[0]["summary_text"].ToString();
                }
                else
                {
                    throw new Exception($"API returned status code {response.StatusCode}. Details: {responseString}");
                }
            }
        }
    }
}