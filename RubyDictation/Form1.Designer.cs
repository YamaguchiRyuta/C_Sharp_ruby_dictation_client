
namespace RubyDictation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rubyIP = new System.Windows.Forms.TextBox();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.rubyConsole = new System.Windows.Forms.TextBox();
            this.rubyUrl = new System.Windows.Forms.Label();
            this.rubyFormat = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rubyIP
            // 
            this.rubyIP.Location = new System.Drawing.Point(25, 25);
            this.rubyIP.Name = "rubyIP";
            this.rubyIP.Size = new System.Drawing.Size(100, 23);
            this.rubyIP.TabIndex = 0;
            this.rubyIP.TextChanged += new System.EventHandler(this.RubyIP_TextChanged);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(236, 25);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(75, 23);
            this.recognizeButton.TabIndex = 1;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.RecognizeButton_Click);
            // 
            // rubyConsole
            // 
            this.rubyConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubyConsole.Location = new System.Drawing.Point(12, 139);
            this.rubyConsole.Multiline = true;
            this.rubyConsole.Name = "rubyConsole";
            this.rubyConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rubyConsole.Size = new System.Drawing.Size(1191, 299);
            this.rubyConsole.TabIndex = 2;
            // 
            // rubyUrl
            // 
            this.rubyUrl.AutoSize = true;
            this.rubyUrl.Location = new System.Drawing.Point(25, 64);
            this.rubyUrl.Name = "rubyUrl";
            this.rubyUrl.Size = new System.Drawing.Size(168, 15);
            this.rubyUrl.TabIndex = 3;
            this.rubyUrl.Text = "RubyDectation WebSocketURL";
            // 
            // rubyFormat
            // 
            this.rubyFormat.AutoSize = true;
            this.rubyFormat.Location = new System.Drawing.Point(25, 83);
            this.rubyFormat.Name = "rubyFormat";
            this.rubyFormat.Size = new System.Drawing.Size(156, 15);
            this.rubyFormat.TabIndex = 4;
            this.rubyFormat.Text = "RubyDectation FormatString";
            // 
            // CheckButton
            // 
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckButton.Location = new System.Drawing.Point(144, 24);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "話者１: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "話者２: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.rubyFormat);
            this.Controls.Add(this.rubyUrl);
            this.Controls.Add(this.rubyConsole);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.rubyIP);
            this.Name = "Form1";
            this.Text = "RubyDectation Client C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rubyIP;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.Label rubyUrl;
        private System.Windows.Forms.Label rubyFormat;
        private System.Windows.Forms.Button CheckButton;
        public System.Windows.Forms.TextBox rubyConsole;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

