using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
    internal class Admin : User, ISoldOut
    {

           
        public void SoldOut(int i)
        {
            MessageBox.Show(new Form { TopMost = true }, food3[i] + "은(가) 품절입니다.");
        }
    }
}
