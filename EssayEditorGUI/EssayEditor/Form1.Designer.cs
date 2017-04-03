namespace EssayEditor
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
            this.essayTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pronounButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.tenseButton = new System.Windows.Forms.Button();
            this.loadFileButton = new System.Windows.Forms.Button();
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
            this.essayTextBox.Size = new System.Drawing.Size(809, 866);
            this.essayTextBox.TabIndex = 0;
            this.essayTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pronounButton);
            this.panel1.Controls.Add(this.voiceButton);
            this.panel1.Controls.Add(this.tenseButton);
            this.panel1.Controls.Add(this.loadFileButton);
            this.panel1.Location = new System.Drawing.Point(834, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 866);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pronounButton
            // 
            this.pronounButton.BackColor = System.Drawing.Color.White;
            this.pronounButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pronounButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pronounButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronounButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pronounButton.Location = new System.Drawing.Point(3, 183);
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
            this.voiceButton.Location = new System.Drawing.Point(3, 123);
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
            this.tenseButton.Location = new System.Drawing.Point(3, 63);
            this.tenseButton.Name = "tenseButton";
            this.tenseButton.Size = new System.Drawing.Size(195, 54);
            this.tenseButton.TabIndex = 1;
            this.tenseButton.Text = "Show Verb Tense";
            this.tenseButton.UseVisualStyleBackColor = false;
            this.tenseButton.Click += new System.EventHandler(this.tenseButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.White;
            this.loadFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.loadFileButton.Location = new System.Drawing.Point(3, 3);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(195, 54);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadFileButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.loadFileButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 890);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.essayTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox essayTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.Button tenseButton;
        private System.Windows.Forms.Button pronounButton;
    }
}

