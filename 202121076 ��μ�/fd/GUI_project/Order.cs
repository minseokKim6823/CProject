using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
    public class Order : Customer,ISoldOut
    {
        public int ramen = 4000;
        public int cupramen = 2000;
        public int shrimp_fried_rice = 5000;//새우
        public int kimchi_fried_rice = 4000;//김치
        public int chicken_fried_rice = 4500;//닭
        public int hv_fried_rice = 4200;//햄야채
        public int tm = 4300;//참치마요
        public int americano = 2000;
        public int latte = 2500;
        public int cappuccino = 2500;
        public int mango_smoodie = 4000;
        public int straw_smoodie = 4000;
        public int cider = 2000;
        public int coke = 2000;
        public int saeuggang = 1400;
        public int ozinguzip = 1500;
        public int potatoChips = 1400;
        public int tornadoPotato = 1500;
        public int shortdari = 2000;
        public int ogamja = 1500;
        public int sunchip = 1500;
        public int peanut = 1800;

        public int Side()
        {
            Price += 500;
            return Price;
        }

        public override void Price_cal(int Food_Price)
        {
            Price += Food_Price;
        }

        public void SoldOut(int i) {
            if (User.food4[i] == 0)
            {
                User.food4[i] -= 1;
                MessageBox.Show("품절 되었습니다.");
            }
            else if (User.food4[i] == 1)
            {
                User.food4[i] -= 1;
                MessageBox.Show("품절 되었습니다.");
            }
            else
                User.food4[i] -= 1;
                
        }
    }
}
