namespace EssayEditor
{
    partial class essayWindow
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
            this.essayTextBox = new EssayEditor.EssayTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusInfo = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pronounButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.tenseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // essayTextBox
            // 
            this.essayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.essayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.essayTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essayTextBox.Location = new System.Drawing.Point(12, 12);
            this.essayTextBox.Name = "essayTextBox";
            this.essayTextBox.shouldRun = true;
            this.essayTextBox.Size = new System.Drawing.Size(809, 866);
            this.essayTextBox.TabIndex = 0;
            this.essayTextBox.Text = "";
            this.essayTextBox.DelayedTextChanged += new System.EventHandler(this.essayTextBox_DelayTextChanged);
            this.essayTextBox.TextChanged += new System.EventHandler(this.essayTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusInfo);
            this.panel1.Controls.Add(this.statsButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.pronounButton);
            this.panel1.Controls.Add(this.voiceButton);
            this.panel1.Controls.Add(this.tenseButton);
            this.panel1.Location = new System.Drawing.Point(834, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 866);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusInfo
            // 
            this.statusInfo.BackColor = System.Drawing.Color.White;
            this.statusInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.statusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusInfo.ForeColor = System.Drawing.Color.Black;
            this.statusInfo.Location = new System.Drawing.Point(2, 303);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(195, 54);
            this.statusInfo.TabIndex = 7;
            this.statusInfo.Text = "Show Statistics";
            this.statusInfo.UseVisualStyleBackColor = false;
            this.statusInfo.Click += new System.EventHandler(this.statusInfo_Click);
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.White;
            this.statsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.statsButton.Location = new System.Drawing.Point(3, 243);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(195, 54);
            this.statsButton.TabIndex = 6;
            this.statsButton.Text = "Show Statistics";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.clearButton.Location = new System.Drawing.Point(3, 183);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(195, 54);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pronounButton
            // 
            this.pronounButton.BackColor = System.Drawing.Color.White;
            this.pronounButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pronounButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pronounButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronounButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pronounButton.Location = new System.Drawing.Point(2, 123);
            this.pronounButton.Name = "pronounButton";
            this.pronounButton.Size = new System.Drawing.Size(195, 54);
            this.pronounButton.TabIndex = 3;
            this.pronounButton.Text = "Show Pronouns";
            this.pronounButton.UseVisualStyleBackColor = false;
            this.pronounButton.Click += new System.EventHandler(this.pronounButton_Click);
            // 
            // voiceButton
            // 
            this.voiceButton.BackColor = System.Drawing.Color.White;
            this.voiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.voiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.voiceButton.Location = new System.Drawing.Point(2, 63);
            this.voiceButton.Name = "voiceButton";
            this.voiceButton.Size = new System.Drawing.Size(195, 54);
            this.voiceButton.TabIndex = 2;
            this.voiceButton.Text = "Show Verb Voice";
            this.voiceButton.UseVisualStyleBackColor = false;
            this.voiceButton.Click += new System.EventHandler(this.voiceButton_Click);
            // 
            // tenseButton
            // 
            this.tenseButton.BackColor = System.Drawing.Color.White;
            this.tenseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.tenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenseButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.tenseButton.Location = new System.Drawing.Point(2, 3);
            this.tenseButton.Name = "tenseButton";
            this.tenseButton.Size = new System.Drawing.Size(195, 54);
            this.tenseButton.TabIndex = 1;
            this.tenseButton.Text = "Show Verb Tense";
            this.tenseButton.UseVisualStyleBackColor = false;
            this.tenseButton.Click += new System.EventHandler(this.tenseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(827, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 867);
            this.panel2.TabIndex = 2;
            // 
            // essayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 890);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.essayTextBox);
            this.Name = "essayWindow";
            this.Text = "Essay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EssayTextBox essayTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.Button tenseButton;
        private System.Windows.Forms.Button pronounButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button statusInfo;
    }
}

