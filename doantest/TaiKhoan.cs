using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doantest
{
    class TaiKhoan
    {
        private string uesrname;
        private string password;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string uesrname, string password)
        {
            this.uesrname = uesrname;
            this.password = password;
        }

        public string Uesrname { get => uesrname; set => uesrname = value; }
        public string Password { get => password; set => password = value; }
    }
}
