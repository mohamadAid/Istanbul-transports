using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class BlueCard:Card
    {
        private String type;
        private int points;

        public string Type { get => type; set => type = value; }
        public int Points { get => points; set => points = value; }

        public BlueCard(int no, String type, int points) : base(no)
        {
            this.Type = type;
            this.points = points;
        }
        public override double transfer(int trans)
        {
            points -= 1;
            return 1;
        }
        public override double metrobus(int stops)
        {
            int a;
            if (stops <= 3)
                a = 1;
            else
                a = 2;
            points -= a;
            return a;
        }
        public override string ToString()
        {
            return base.ToString() + " type=" + Type + " points=" + points;
        }
    }
}
