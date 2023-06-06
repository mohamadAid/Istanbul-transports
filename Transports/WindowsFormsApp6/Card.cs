using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public abstract class Card
    {
        private int no;

        public int No { get => no; set => no = value; }

        public Card(int no)
        {
            this.No = no;
        }
        public abstract double transfer(int trans);
        public abstract double metrobus(int stops);
        public override string ToString()
        {
            return "no=" + No;
        }
    }
}
