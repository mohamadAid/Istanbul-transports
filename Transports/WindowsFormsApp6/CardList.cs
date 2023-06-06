using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public abstract class CardList
    {
        private List<Card> _clist = new List<Card>();
        public CardList()
        {
            this.CreateCardList();
        }
        public List<Card> Clist
        {
            get { return _clist; }
        }
        public abstract void CreateCardList();

        internal DataGridView _Clist()
        {
            throw new NotImplementedException();
        }
    }
}

