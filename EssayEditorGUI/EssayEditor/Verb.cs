using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EssayEditor
{
    class Verb : Location
    {
        private int voice;
        private int tense;
        public Verb(int start, int length, int voice, int tense) : base(start, length)
        {
            this.voice = voice;
            this.tense = tense;
        }
       
        public Color getVoiceColor()
        {
            if(voice == 1)
            {
                switch(tense)
                {
                    case 0:
                        return Color.FromArgb(236, 211, 243);
                    case 1:
                        return Color.FromArgb(209, 160, 221);
                    case 2:
                        return Color.FromArgb(177, 112, 193);
                }
            } else
            {
                switch (tense)
                {
                    case 2:
                        return Color.FromArgb(148, 218, 94);
                    case 0:
                        return Color.FromArgb(204, 244, 174);
                    case 1:
                        return Color.FromArgb(177, 234, 133);
                }
            }
            return Color.White;
        }


        public Color getTenseColor()
        {
            if (voice == 1)
            {
                switch (tense)
                {
                    case 0:
                        return Color.FromArgb(252, 194, 200);
                    case 1:
                        return Color.FromArgb(180, 195, 226);
                    case 2:
                        return Color.FromArgb(255, 252, 197);
                }
            }
            else
            {
                switch (tense)
                {
                    case 0:
                        return Color.FromArgb(249, 152, 161);
                    case 1:
                        return Color.FromArgb(128, 150, 197);
                    case 2:
                        return Color.FromArgb(255, 251, 156);
                }
            }
            return Color.White;
        }
    }
}
