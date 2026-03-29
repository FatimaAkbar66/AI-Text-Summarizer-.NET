using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace AI_Text_Summarizer
{
    public partial class Form1 : Form
    {
        // Keep track of the selected summarization format
        private string summaryFormat = "Paragraph";

        public Form1()
        {
            InitializeComponent();

            // 1. Force the window to open at a large, specific size (Width: 1250, Height: 750)
            this.Size = new Size(1050, 520);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 2. This keeps your central card perfectly centered no matter what!
            pnlCentralCard.Left = (this.ClientSize.Width - pnlCentralCard.Width) / 2;
            pnlCentralCard.Top = (this.ClientSize.Height - pnlCentralCard.Height) / 2;

            // Wire up the placeholder, word count, and format button events
            txtInput.Enter += TxtInput_Enter;
            txtInput.Leave += TxtInput_Leave;
            txtInput.TextChanged += TxtInput_TextChanged;

            btnParagraph.Click += BtnParagraph_Click;
            btnBulletPoints.Click += BtnBulletPoints_Click;

            // Set initial active button styling
            SetActiveButtonStyling();
        }

        private async void btnSummarize_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(inputText) || inputText == "Paste your text here...")
            {
                MessageBox.Show("Please enter some text to summarize.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update UI to show loading state
            btnSummarize.Enabled = false;
            btnSummarize.Text = "Processing...";
            txtOutput.Text = "Generating summary...";

            try
            {
                // Call the API and update the output box
                string summary = await GetSummaryFromAI(inputText);
                txtOutput.Text = summary;

                // Update output word count
                lblOutputWordCount.Text = $"Words: {CountWords(summary)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOutput.Text = "Failed to generate summary.";
            }
            finally
            {
                // Re-enable the button when done
                btnSummarize.Enabled = true;
                btnSummarize.Text = "Summarize";
            }
        }

        private async Task<string> GetSummaryFromAI(string text)
        {
            // 1. Put your Gemini API key here
            string geminiApiKey = "API_KEY";

            // 2. Stable gemini-2.5-flash
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={geminiApiKey}";

            // 3. We change the instruction sent to Gemini based on the button selected!
            string promptInstruction = "Summarize the following text concisely in a short paragraph: ";
            if (summaryFormat == "Bullet Points")
            {
                promptInstruction = "Summarize the following text using clear, concise bullet points (use '-' for bullets): ";
            }

            using (HttpClient client = new HttpClient())
            {
                var requestBody = new
                {
                    contents = new[]
                    {
                        new { parts = new[] { new { text = promptInstruction + text } } }
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
                    JObject json = JObject.Parse(responseString);
                    string summary = json["candidates"][0]["content"]["parts"][0]["text"].ToString();
                    return summary.Trim();
                }
                else
                {
                    throw new Exception($"Gemini API Error: {response.StatusCode}. Details: {responseString}");
                }
            }
        }

        // --- BUTTON CLICK EVENTS FOR UI TOGGLE ---

        private void BtnParagraph_Click(object sender, EventArgs e)
        {
            summaryFormat = "Paragraph";
            SetActiveButtonStyling();
        }

        private void BtnBulletPoints_Click(object sender, EventArgs e)
        {
            summaryFormat = "Bullet Points";
            SetActiveButtonStyling();
        }

        private void SetActiveButtonStyling()
        {
            if (summaryFormat == "Paragraph")
            {
                // Paragraph button becomes blue, bullet points becomes gray
                btnParagraph.BackColor = Color.FromArgb(65, 105, 225);
                btnParagraph.ForeColor = Color.White;

                btnBulletPoints.BackColor = Color.FromArgb(240, 240, 245);
                btnBulletPoints.ForeColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                // Bullet Points button becomes blue, paragraph becomes gray
                btnBulletPoints.BackColor = Color.FromArgb(65, 105, 225);
                btnBulletPoints.ForeColor = Color.White;

                btnParagraph.BackColor = Color.FromArgb(240, 240, 245);
                btnParagraph.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        // --- HELPER EVENTS FOR MODERN UX ---

        private void TxtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text == "Paste your text here...")
            {
                txtInput.Text = "";
                txtInput.ForeColor = Color.FromArgb(25, 25, 40);
            }
        }

        private void TxtInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtInput.Text = "Paste your text here...";
                txtInput.ForeColor = Color.FromArgb(120, 120, 120);
            }
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text != "Paste your text here...")
            {
                lblInputWordCount.Text = $"Words: {CountWords(txtInput.Text)}";
            }
            else
            {
                lblInputWordCount.Text = "Words: 0";
            }
        }

        private int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;

            string[] words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // --- BACKGROUND PAINTING ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(215, 245, 245),
                Color.FromArgb(245, 225, 250),
                45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnParagraph_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBulletPoints_Click_1(object sender, EventArgs e)
        {

        }
    }
}