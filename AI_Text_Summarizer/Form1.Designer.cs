namespace AI_Text_Summarizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlCentralCard;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBottomBar;
        private System.Windows.Forms.Label lblInputWordCount;
        private System.Windows.Forms.Label lblOutputWordCount;
        private System.Windows.Forms.Button btnParagraph;
        private System.Windows.Forms.Button btnBulletPoints;

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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlCentralCard = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnParagraph = new System.Windows.Forms.Button();
            this.btnBulletPoints = new System.Windows.Forms.Button();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.lblInputWordCount = new System.Windows.Forms.Label();
            this.lblOutputWordCount = new System.Windows.Forms.Label();
            this.pnlCentralCard.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.Lavender;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtInput.Location = new System.Drawing.Point(17, 81);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(622, 376);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Paste your text here...";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtOutput.Location = new System.Drawing.Point(646, 81);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(622, 376);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "Your summary will appear here...";
            // 
            // btnSummarize
            // 
            this.btnSummarize.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSummarize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummarize.FlatAppearance.BorderSize = 0;
            this.btnSummarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSummarize.ForeColor = System.Drawing.Color.White;
            this.btnSummarize.Location = new System.Drawing.Point(606, 652);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(169, 45);
            this.btnSummarize.TabIndex = 0;
            this.btnSummarize.Text = "Summarize";
            this.btnSummarize.UseVisualStyleBackColor = false;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHeader.Location = new System.Drawing.Point(360, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(773, 61);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Summarize any text with One Click";
            // 
            // pnlCentralCard
            // 
            this.pnlCentralCard.BackColor = System.Drawing.Color.White;
            this.pnlCentralCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentralCard.Controls.Add(this.txtInput);
            this.pnlCentralCard.Controls.Add(this.txtOutput);
            this.pnlCentralCard.Controls.Add(this.pnlTopBar);
            this.pnlCentralCard.Controls.Add(this.pnlBottomBar);
            this.pnlCentralCard.Location = new System.Drawing.Point(45, 110);
            this.pnlCentralCard.Name = "pnlCentralCard";
            this.pnlCentralCard.Size = new System.Drawing.Size(1283, 536);
            this.pnlCentralCard.TabIndex = 1;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnParagraph);
            this.pnlTopBar.Controls.Add(this.btnBulletPoints);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1281, 63);
            this.pnlTopBar.TabIndex = 2;
            // 
            // btnParagraph
            // 
            this.btnParagraph.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnParagraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParagraph.ForeColor = System.Drawing.Color.White;
            this.btnParagraph.Location = new System.Drawing.Point(17, 10);
            this.btnParagraph.Name = "btnParagraph";
            this.btnParagraph.Size = new System.Drawing.Size(101, 37);
            this.btnParagraph.TabIndex = 0;
            this.btnParagraph.Text = "Paragraph";
            this.btnParagraph.UseVisualStyleBackColor = false;
            this.btnParagraph.Click += new System.EventHandler(this.btnParagraph_Click_1);
            // 
            // btnBulletPoints
            // 
            this.btnBulletPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBulletPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulletPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBulletPoints.Location = new System.Drawing.Point(124, 10);
            this.btnBulletPoints.Name = "btnBulletPoints";
            this.btnBulletPoints.Size = new System.Drawing.Size(117, 37);
            this.btnBulletPoints.TabIndex = 1;
            this.btnBulletPoints.Text = "Bullet Points";
            this.btnBulletPoints.UseVisualStyleBackColor = false;
            this.btnBulletPoints.Click += new System.EventHandler(this.btnBulletPoints_Click_1);
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.White;
            this.pnlBottomBar.Controls.Add(this.lblInputWordCount);
            this.pnlBottomBar.Controls.Add(this.lblOutputWordCount);
            this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBar.Location = new System.Drawing.Point(0, 474);
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.Size = new System.Drawing.Size(1281, 60);
            this.pnlBottomBar.TabIndex = 3;
            // 
            // lblInputWordCount
            // 
            this.lblInputWordCount.AutoSize = true;
            this.lblInputWordCount.ForeColor = System.Drawing.Color.Gray;
            this.lblInputWordCount.Location = new System.Drawing.Point(17, 15);
            this.lblInputWordCount.Name = "lblInputWordCount";
            this.lblInputWordCount.Size = new System.Drawing.Size(72, 20);
            this.lblInputWordCount.TabIndex = 0;
            this.lblInputWordCount.Text = "Words: 0";
            // 
            // lblOutputWordCount
            // 
            this.lblOutputWordCount.AutoSize = true;
            this.lblOutputWordCount.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputWordCount.Location = new System.Drawing.Point(1125, 15);
            this.lblOutputWordCount.Name = "lblOutputWordCount";
            this.lblOutputWordCount.Size = new System.Drawing.Size(72, 20);
            this.lblOutputWordCount.TabIndex = 1;
            this.lblOutputWordCount.Text = "Words: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1385, 720);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.pnlCentralCard);
            this.Controls.Add(this.lblHeader);
            this.MinimumSize = new System.Drawing.Size(1347, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Text Summarizer";
            this.pnlCentralCard.ResumeLayout(false);
            this.pnlCentralCard.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}