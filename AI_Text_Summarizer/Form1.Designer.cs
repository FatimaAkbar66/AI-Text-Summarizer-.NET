namespace AI_Text_Summarizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSummarize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(190, 41, 236); // Neon Purple
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 41);
            this.lblTitle.Text = "AI Text Summarizer";

            // txtInput
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(30, 30, 36);
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(35, 80);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(400, 250);
            this.txtInput.Text = "Paste your long article or text here...";

            // txtOutput
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(30, 30, 36);
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0); // Neon Orange text for output
            this.txtOutput.Location = new System.Drawing.Point(460, 80);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(400, 250);
            this.txtOutput.Text = "AI Summary will appear here...";

            // btnSummarize
            this.btnSummarize.BackColor = System.Drawing.Color.FromArgb(190, 41, 236); // Neon Purple
            this.btnSummarize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummarize.FlatAppearance.BorderSize = 0;
            this.btnSummarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSummarize.ForeColor = System.Drawing.Color.White;
            this.btnSummarize.Location = new System.Drawing.Point(35, 350);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(825, 50);
            this.btnSummarize.Text = "Generate Summary";
            this.btnSummarize.UseVisualStyleBackColor = false;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblStatus.Location = new System.Drawing.Point(35, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.Text = "Status: Ready";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18); // Deep Dark background
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Text Summarizer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}