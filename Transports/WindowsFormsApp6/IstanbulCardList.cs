using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class IstanbulCardList : CardList
    {
            public override void CreateCardList()
        {
            IstanbulCard is1 = new IstanbulCard(100, "full", 100);
            is1.transfer(0);
            is1.transfer(1);
            is1.transfer(2);
            is1.metrobus(25);
            IstanbulCard is2 = new IstanbulCard(200, "student", 50);
            is2.transfer(0);
            is2.transfer(1);
            is2.transfer(2);
            is2.metrobus(25);
            IstanbulCard is3 = new IstanbulCard(300, "teacher", 200);
            is3.transfer(0);
            is3.transfer(1);
            is3.transfer(2);
            is3.metrobus(25);
            Clist.Add(is1);
            Clist.Add(is2);
            Clist.Add(is3);
           
        }
    }
    }


