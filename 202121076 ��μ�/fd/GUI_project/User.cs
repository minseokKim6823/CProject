using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
  
    public class User
    {
        public bool x = false;
        public string s;

        public string S
        {
            get { return s; }
            set { s = value; }
        }


        public string admin_id = "ID";
        public string admin_pass = "PWPWPW";


        public void Login(string pw, string id)
        {


            string folder = @"C:\Users\김민석\Documents\데이터.txt";


            string txtVal = System.IO.File.ReadAllText(folder);

            if (txtVal.Contains(pw) == true && txtVal.Contains(id) == true)
            {
                x = true;
                MessageBox.Show(" 로그인 성공");
            }
            else
            {
                MessageBox.Show(" 아이디(로그인 전용 아이디) 또는 비밀번호를 잘못 입력했습니다" + "\n" + "입력하신 내용을 다시 확인해주세요.");
            }
        }






        public string[] food3 = new string[] { "새우깡", "땅콩", "숏다리", "썬칩", "오감자", "오징어집", "포테토칩", "회오리감자", "라면", "컵라면", "새우볶음밥", "김치볶음밥", "닭가슴살볶음밥", "햄야채볶음밥", "참치마요볶음밥", "아메리카노", "카페라떼", "카푸치노", "망고스무디", "딸기스무디", "콜라", "사이다", "계란", "떡", "모짜렐라치즈", "체다치즈", "밥" };
        public static int[] food4 = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

    }
}
