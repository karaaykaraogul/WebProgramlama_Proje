using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class User
    {
        public int userID { get; set; }//PK
        public string userName { get; set; }
        public string userPass { get; set; }
        public string userMail { get; set; }
        public int userWallet { get; set; }
        public int userIsAdmin { get; set; }
        public string userImg { get; set; }

    }
}
