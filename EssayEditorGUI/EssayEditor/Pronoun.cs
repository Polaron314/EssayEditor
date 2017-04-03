using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EssayEditor
{
    class Pronoun : Location
    {
        private int person;
        public Pronoun(int start, int length, int person) : base(start, length)
        {
            this.person = person;
        }

        public Color getColor()
        {
            switch(person)
            {
                case 1:
                    return Color.FromArgb(146, 196, 210);
                case 2:
                    return Color.FromArgb(255, 245, 174);
                case 3:
                    return Color.FromArgb(234, 160, 198);
            }
            return Color.Wheat;
        }
    }
}
