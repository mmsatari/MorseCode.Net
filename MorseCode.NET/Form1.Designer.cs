namespace MorseCode.NET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.txtMorseCode = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbxWPM = new System.Windows.Forms.ComboBox();
            this.cbxFrequency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.Location = new System.Drawing.Point(12, 33);
            this.txtOriginalText.Multiline = true;
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.Size = new System.Drawing.Size(664, 120);
            this.txtOriginalText.TabIndex = 0;
            this.txtOriginalText.Text = "Text to convert to morse";
            // 
            // txtMorseCode
            // 
            this.txtMorseCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseCode.Location = new System.Drawing.Point(12, 194);
            this.txtMorseCode.Multiline = true;
            this.txtMorseCode.Name = "txtMorseCode";
            this.txtMorseCode.Size = new System.Drawing.Size(664, 187);
            this.txtMorseCode.TabIndex = 1;
            this.txtMorseCode.Text = "... --- ...";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(13, 160);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(106, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert To Morse";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(125, 160);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbxWPM
            // 
            this.cbxWPM.FormattingEnabled = true;
            this.cbxWPM.Items.AddRange(new object[] {
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbxWPM.Location = new System.Drawing.Point(241, 160);
            this.cbxWPM.Name = "cbxWPM";
            this.cbxWPM.Size = new System.Drawing.Size(121, 21);
            this.cbxWPM.TabIndex = 4;
            this.cbxWPM.Text = "20";
            // 
            // cbxFrequency
            // 
            this.cbxFrequency.FormattingEnabled = true;
            this.cbxFrequency.Items.AddRange(new object[] {
            "400",
            "450",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "1000",
            "1050",
            "1100",
            "1150",
            "1200",
            "1250",
            "1300"});
            this.cbxFrequency.Location = new System.Drawing.Point(424, 160);
            this.cbxFrequency.Name = "cbxFrequency";
            this.cbxFrequency.Size = new System.Drawing.Size(121, 21);
            this.cbxFrequency.TabIndex = 5;
            this.cbxFrequency.Text = "600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "WPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Freq";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFrequency);
            this.Controls.Add(this.cbxWPM);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMorseCode);
            this.Controls.Add(this.txtOriginalText);
            this.Name = "Form1";
            this.Text = "MorseCode.NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginalText;
        private System.Windows.Forms.TextBox txtMorseCode;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbxWPM;
        private System.Windows.Forms.ComboBox cbxFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

