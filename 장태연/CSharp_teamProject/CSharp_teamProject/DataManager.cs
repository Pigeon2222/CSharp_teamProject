using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_teamProject
{
    public class DataManager
    {

        public usertable_ty Mypage_info(string id)
        {
            DBHelper dbh = new DBHelper();

            usertable_ty ust = dbh.DBMypage(id);

            return ust;
        }
       
    }
}
