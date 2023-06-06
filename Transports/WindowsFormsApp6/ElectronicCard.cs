using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class ElectronicCard:Card
    {
        private int points;

        public int Points { get => points; set => points = value; }

        public ElectronicCard(int no, int points) : base(no)
        {
            this.Points = points;
        }
        public override double transfer(int trans)
        {
            Points -= 1;
            return 1;
        }
        public override double metrobus(int stops)
        {
            int a;
            if (stops <= 3)
                a = 1;
            else
                a = 2;
            Points -= a;
            return a;
        }
        public override string ToString()
        {
            return base.ToString() + " points=" + Points;
        }
    }
}
