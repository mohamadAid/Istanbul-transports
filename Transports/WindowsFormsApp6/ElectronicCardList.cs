using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class ElectronicCardList:CardList
    {
        public override void CreateCardList()
        {
            //ElectronicCard e1 = new ElectronicCard(700, 10);
            Clist.Add(new ElectronicCard(2,14 ));
        }
    }
}
