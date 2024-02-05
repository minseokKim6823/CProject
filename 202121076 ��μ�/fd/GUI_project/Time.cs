using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
    internal class Time : Customer
    {
        private int duration; // 바깥형식과 같은 이름 사용불가

        public int Duration // 바깥형식과 같은 이름 사용불가
        {
            get { return duration; }
            set { duration = value; }
        }


        public void Count_down()
        {
            if (duration == 0)
            {
                MessageBox.Show("사용 시간이 마감되었습니다. 시스템을 종료합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
            else if (duration > 0)
            {
                duration--;
            }
        }


        public override void Price_cal(int Time_Price)
        {
            Price += Time_Price;
        }

        
        
    }
}
