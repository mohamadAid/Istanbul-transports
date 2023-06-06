using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class IstanbulCard:Card
    {
        private String type;
        private double balance;
        public string Type { get => type; set => type = value; }
        public double Balance { get => balance; set => balance = value; }
       

        public IstanbulCard(int no, String type, double balance) : base(no)
        {
            this.Type = type;
            this.Balance = balance;
           
        }
        public override double transfer(int trans)
        {
            double a;
            switch (Type)
            {
                case "Full fare":
                    switch (trans)
                    {
                        case 0: a = 2.6; break;
                        case 1: a = 1.85; break;
                        case 2: a = 1.4; break;
                        case 3: case 4: case 5: a = 0.9; break;
                        default: a = 0; break;
                    }
                    break;
                case "Student":
                    switch (trans)
                    {
                        case 0: a = 1.25; break;
                        case 1: a = 0.55; break;
                        case 2: a = 0.50; break;
                        case 3: case 4: case 5: a = 0.45; break;
                        default: a = 0; break;
                    }
                    break;
                case "Teacher":
                    switch (trans)
                    {
                        case 0: a = 1.85; break;
                        case 1: a = 1.1; break;
                        case 2: a = 0.85; break;
                        case 3: case 4: case 5: a = 0.55; break;
                        default: a = 0; break;
                    }
                    break;
                default: a = 0; break;
            }
            Balance -= a;
            return a;
        }
        public override double metrobus(int stops)
        {
            double a;
            switch (Type)
            {
                case "Full fare":
                    if (stops <= 3)
                        a = 1.95;
                    else if (stops <= 9)
                        a = 3;
                    else if (stops <= 15)
                        a = 3.25;
                    else if (stops <= 21)
                        a = 3.4;
                    else if (stops <= 27)
                        a = 3.5;
                    else if (stops <= 33)
                        a = 3.6;
                    else
                        a = 3.85;
                    break;
                case "Student":
                    if (stops <= 3)
                        a = 1.1;
                    else if (stops <= 9)
                        a = 1.2;
                    else
                        a = 1.25;
                    break;
                case "Teacher":
                    if (stops <= 3)
                        a = 1.45;
                    else if (stops <= 9)
                        a = 1.85;
                    else if (stops <= 15)
                        a = 1.9;
                    else if (stops <= 27)
                        a = 2;
                    else
                        a = 2.1;
                    break;
                default: a = 0; break;
            }
            Balance -= a;
            return a;
        }
        public override string ToString()
        {
            return base.ToString() + " type=" + Type + " balance=" + Balance;
        }
    }
}
