using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class BlueCardList:CardList
    {
        public override void CreateCardList()
        {
            BlueCard b1 = new BlueCard(400, "full", 200);
            b1.transfer(0);
            b1.transfer(1);
            b1.transfer(2);
            b1.metrobus(25);
            BlueCard b2 = new BlueCard(500, "student", 150);
            b2.transfer(0);
            b2.transfer(1);
            b2.transfer(2);
            b2.metrobus(25);
            BlueCard b3 = new BlueCard(600, "teacher", 75);
            b3.transfer(0);
            b3.transfer(1);
            b3.transfer(2);
            b3.metrobus(25);

            Clist.Add(b1);
            Clist.Add(b2);
            Clist.Add(b3);
        }
    }
}
