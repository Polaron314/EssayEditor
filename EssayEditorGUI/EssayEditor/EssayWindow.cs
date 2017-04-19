using edu.sacredheart.jtowner.nlp;
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
        bool computed = false;
        Essay essay;
        int[] sentenceStarts;
        public essayWindow()
        {
            InitializeComponent();
            this.buttonsAccess();
            this.essay = new Essay();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /**private void button1_MouseEnter(object sender, EventArgs e)
        {
            runButton.BackColor = Color.FromArgb(255, 3, 44, 84);
            runButton.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            runButton.BackColor = Color.FromArgb(255, 255, 255, 255);
            runButton.ForeColor = Color.FromArgb(255, 3, 44, 84); ;
        }**/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void highlightText(int start, int length, Color back, Color fore)
        {
            essayTextBox.shouldRun = false;
            essayTextBox.Select(start, length);
            essayTextBox.SelectionColor = fore;
            essayTextBox.SelectionBackColor = back;
            essayTextBox.shouldRun = true;
        }

        private void highlightVoiceText(Verb v)
        {
            essayTextBox.shouldRun = false;
            int sentence = v.getSentence();
            int start = essay.getSpan(sentence, v.getTokenStart()).getStart() + this.sentenceStarts[sentence];
            int length = essay.getSpan(sentence, v.getTokenStart() + v.getLength() - 1).getEnd() - start + this.sentenceStarts[sentence];
            essayTextBox.Select(start, length);
            essayTextBox.SelectionColor = Color.Black;
            Color c;

            switch(v.getTense())
            {
                case 0:
                    if(v.getVoice() == 0)
                    {
                        c = Color.FromArgb(255, 230, 178);
                        break;
                    } else
                    {
                        c = Color.FromArgb(247, 216, 255);
                        break;
                    }
                case 1:
                    if (v.getVoice() == 0)
                    {
                        c = Color.FromArgb(249, 203, 159);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(222, 158, 255);
                        break;
                    }
                case 2:
                    if (v.getVoice() == 0)
                    {
                        c = Color.FromArgb(252, 172, 128);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(181, 138, 242);
                        break;
                    }
                default:
                    c = Color.White;
                    break;
            }

            essayTextBox.SelectionBackColor = c;
            essayTextBox.shouldRun = true;
        }

        private void highlightTenseText(Verb v)
        {
            essayTextBox.shouldRun = false;
            int sentence = v.getSentence();
            int start = essay.getSpan(sentence, v.getTokenStart()).getStart() + this.sentenceStarts[sentence];
            int length = essay.getSpan(sentence, v.getTokenStart() + v.getLength() - 1).getEnd() - start + this.sentenceStarts[sentence];
            essayTextBox.Select(start, length);
            essayTextBox.SelectionColor = Color.Black;
            Color c;

            switch (v.getTense())
            {
                case 0:
                    if (v.getVoice() == 0)
                    {
                        c = Color.FromArgb(226, 235, 255);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(204, 217, 255);
                        break;
                    }
                case 1:
                    if (v.getVoice() == 0)
                    {
                        c = Color.FromArgb(230, 255, 204);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(182, 225, 205);
                        break;
                    }
                case 2:
                    if (v.getVoice() == 0)
                    {
                        c = Color.FromArgb(255, 226, 247);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(242, 174, 219);
                        break;
                    }
                default:
                    c = Color.White;
                    break;
            }

            essayTextBox.SelectionBackColor = c;
            essayTextBox.shouldRun = true;
        }

        private void highlightPronounText(Pronoun p)
        {
            essayTextBox.shouldRun = false;
            int sentence = p.getSentence();
            int start = essay.getSpan(sentence, p.getTokenStart()).getStart() + this.sentenceStarts[sentence];
            int length = essay.getSpan(sentence, p.getTokenStart() + p.getLength() - 1).getEnd() - start + this.sentenceStarts[sentence];
            essayTextBox.Select(start, length);
            essayTextBox.SelectionColor = Color.Black;
            Color c;

            switch (p.getPerson())
            {
                case 1:
                    if (p.getNumber() == 0)
                    {
                        c = Color.FromArgb(255, 234, 175);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(255, 228, 151);
                        break;
                    }
                case 2:
                    c = Color.FromArgb(212, 216, 252);
                    break;
                case 3:
                    if (p.getNumber() == 0)
                    {
                        c = Color.FromArgb(255, 208, 209);
                        break;
                    }
                    else
                    {
                        c = Color.FromArgb(255, 175, 177);
                        break;
                    }
                default:
                    c = Color.White;
                    break;
            }

            essayTextBox.SelectionBackColor = c;
            essayTextBox.shouldRun = true;
        }

        private void tenseButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Verb[] verbs = essay.getVerbArray();
            foreach(Verb v in verbs) {
                this.highlightTenseText(v);
            }
        }

        private void voiceButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Verb[] verbs = essay.getVerbArray();
            foreach (Verb v in verbs)
            {
                this.highlightVoiceText(v);
            }
        }

        private void pronounButton_Click(object sender, EventArgs e)
        {
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            Pronoun[] pronouns = essay.getPronounArray();
            foreach (Pronoun p in pronouns)
            {
                this.highlightPronounText(p);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            this.updateStatusButton(1);
            string text = this.essayTextBox.Text;
            this.essay.update(text);
            this.sentenceStarts = this.essay.getSentenceStarts();
        }

        private void buttonsAccess()
        {
            if (computed)
            {
                //this.essayTextBox.ReadOnly = false;
                this.updateStatusButton(2);
                this.clearButton.Enabled = true;
                this.statsButton.Enabled = true;
                this.tenseButton.Enabled = true;
                this.voiceButton.Enabled = true;
                this.pronounButton.Enabled = true;
            } else
            {
                //this.essayTextBox.ReadOnly = false;
                this.clearButton_Click(null, null);
                essayTextBox.shouldRun = true;
                this.clearButton.Enabled = false;
                this.statsButton.Enabled = false;
                this.tenseButton.Enabled = false;
                this.voiceButton.Enabled = false;
                this.pronounButton.Enabled = false;
                this.updateStatusButton(0);
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            essayTextBox.shouldRun = false;
            int i = essayTextBox.SelectionStart;
            this.highlightText(0, this.essayTextBox.Text.Length, Color.White, Color.Black);
            this.essayTextBox.DeselectAll();
            essayTextBox.SelectionStart = i;
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            StatisticsWindow sw = new StatisticsWindow(this.essay);
            sw.Show();
        }

        private void essayTextBox_DelayTextChanged(object sender, EventArgs e)
        {
            this.runButton_Click(sender, e);
            this.computed = true;
            this.buttonsAccess();
        }

        private void essayTextBox_TextChanged(object sender, EventArgs e)
        {
            if (computed == true && essayTextBox.shouldRun) { 
                this.computed = false;
                this.buttonsAccess();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void updateStatusButton(int status)
        {
            switch(status)
            {
                case 0:
                    statusInfo.Enabled = true;
                    statusInfo.BackColor = Color.FromArgb(96, 12, 0);
                    statusInfo.ForeColor = Color.White;
                    statusInfo.Text = "Not Processed";
                    break;
                case 1:
                    statusInfo.Enabled = false;
                    statusInfo.BackColor = Color.FromArgb(243, 247, 145);
                    statusInfo.ForeColor = Color.White;
                    statusInfo.Text = "Processing...";
                    break;
                case 2:
                    statusInfo.Enabled = false;
                    statusInfo.BackColor = Color.FromArgb(150, 255, 152);
                    statusInfo.ForeColor = Color.White;
                    statusInfo.Text = "Processed";
                    break;
            }
        }

        private void statusInfo_Click(object sender, EventArgs e)
        {
            this.runButton_Click(null, null);
        }
    }
}
