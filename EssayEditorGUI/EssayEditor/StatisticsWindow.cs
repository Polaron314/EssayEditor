using edu.sacredheart.jtowner.nlp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EssayEditor
{
    public partial class StatisticsWindow : Form
    {
        Essay essay;
        public StatisticsWindow(Essay essay)
        {
            InitializeComponent();
            this.essay = essay;
            this.initCharts();
            this.initTextboxes();
        }

        private void initTextboxes()
        {
            string[] lines = essay.getCommonWords();
            this.characterLabel.Text += essay.getCharCount();
            this.wcLabel.Text += essay.getWordCount();
            this.scLabel.Text += essay.getSentenceCount();
            this.frequencyLabel.Text = "";
            foreach(string s in lines) {
                this.frequencyLabel.Text += s + Environment.NewLine;
            }
        }

        private void initCharts()
        {
            int past = 0, present = 0, future = 0, active = 0, passive = 0;

            Verb[] verbs = essay.getVerbArray();
            foreach(Verb v in verbs) {
                switch(v.getTense()) {
                    case 0:
                        past++;
                        break;
                    case 1:
                        present++;
                        break;
                    case 2:
                        future++;
                        break;
                }
                switch(v.getVoice())
                {
                    case 0:
                        active++;
                        break;
                    case 1:
                        passive++;
                        break;
                }
            }

            tenseChart.Series.ElementAt(0).Points.ElementAt(0).YValues = new double[] { past };
            tenseChart.Series.ElementAt(0).Points.ElementAt(1).YValues = new double[] { present };
            tenseChart.Series.ElementAt(0).Points.ElementAt(2).YValues = new double[] { future };
            voiceChart.Series.ElementAt(0).Points.ElementAt(0).YValues = new double[] { active };
            voiceChart.Series.ElementAt(0).Points.ElementAt(1).YValues = new double[] { passive };

            int first = 0, second = 0, third = 0;

            Pronoun[] pronouns = essay.getPronounArray();
            foreach(Pronoun p in pronouns)
            {
                switch(p.getPerson())
                {
                    case 1:
                        first++;
                        break;
                    case 2:
                        second++;
                        break;
                    case 3:
                        third++;
                        break;
                }
            }
            
            pronounChart.Series.ElementAt(0).Points.ElementAt(0).YValues = new double[] { first };
            pronounChart.Series.ElementAt(0).Points.ElementAt(1).YValues = new double[] { second };
            pronounChart.Series.ElementAt(0).Points.ElementAt(2).YValues = new double[] { third };
        }

        private void tenseChart_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void voiceChart_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flowLayoutPanel2.ClientRectangle, Color.FromArgb(220,220,200), ButtonBorderStyle.Solid);
        }

        private void characterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
