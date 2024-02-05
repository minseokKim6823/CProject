using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_project
{
    abstract public class Customer : User
    {
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public abstract void Price_cal(int price);

    }
}
