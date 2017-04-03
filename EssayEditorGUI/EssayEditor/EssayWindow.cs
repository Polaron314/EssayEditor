using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EssayEditor
{
    public partial class essayWindow : Form
    {
        bool isEditable = true;
        public essayWindow()
        {
            InitializeComponent();
            this.buttonsAccess();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            loadFileButton.BackColor = Color.FromArgb(255, 3, 44, 84);
            loadFileButton.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            loadFileButton.BackColor = Color.FromArgb(255, 255, 255, 255);
            loadFileButton.ForeColor = Color.FromArgb(255, 3, 44, 84); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.isEditable = true;
            this.buttonsAccess();
        }

        private void highlightText(int start, int length, Color back, Color fore)
        {
            essayTextBox.Select(start, length);
            essayTextBox.SelectionColor = fore;
            essayTextBox.SelectionBackColor = back;
        }

        private void highlightVoiceText(Verb l)
        {
            essayTextBox.Select(l.getStart(), l.getLength());
            essayTextBox.SelectionColor = Color.Black;
            essayTextBox.SelectionBackColor = l.getVoiceColor();
        }

        private void highlightTenseText(Verb l)
        {
            essayTextBox.Select(l.getStart(), l.getLength());
            essayTextBox.SelectionColor = Color.Black;
            essayTextBox.SelectionBackColor = l.getTenseColor();
        }

        private void highlightPronounText(Pronoun l)
        {
            essayTextBox.Select(l.getStart(), l.getLength());
            essayTextBox.SelectionColor = Color.Black;
            essayTextBox.SelectionBackColor = l.getColor();
        }

        private FileImporter fi = new FileImporter();

        private void tenseButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Verb[] verbs = fi.getVerbs();
            foreach (Verb l in verbs)
            {
                this.highlightTenseText(l);
            }
        }

        private void voiceButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Verb[] verbs = fi.getVerbs();
            foreach (Verb l in verbs)
            {
                this.highlightVoiceText(l);
            }
        }

        private void pronounButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Pronoun[] pronouns = fi.getPronouns();
            foreach (Pronoun p in pronouns)
            {
                this.highlightPronounText(p);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string text = this.essayTextBox.Text;
            System.IO.File.WriteAllText("essay.txt", text);
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = @"-jar " + "EssayEditor.jar";
            clientProcess.Start();
            clientProcess.WaitForExit();
            this.essayTextBox.Text = fi.getEssayText();
            isEditable = false;
            this.buttonsAccess();
        }

        private void buttonsAccess()
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            if (isEditable)
            {
                this.essayTextBox.ReadOnly = false;
                this.runButton.Enabled = true;
                this.loadFileButton.Enabled = false;
                this.tenseButton.Enabled = false;
                this.voiceButton.Enabled = false;
                this.pronounButton.Enabled = false;
            } else
            {
                this.essayTextBox.ReadOnly = true;
                this.runButton.Enabled = false;
                this.loadFileButton.Enabled = true;
                this.tenseButton.Enabled = true;
                this.voiceButton.Enabled = true;
                this.pronounButton.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
        }

        private void statsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
