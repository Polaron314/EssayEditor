using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssayEditor
{
    class Location
    {
        private int start;
        private int length;
        public Location(int start, int length)
        {
            this.start = start;
            this.length = length;
        }

        public int getStart()
        {
            return start;
        }

        public int getLength()
        {
            return length;
        }
    }
}
