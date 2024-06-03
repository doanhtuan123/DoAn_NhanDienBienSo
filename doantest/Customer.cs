using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doantest
{
    class Customer
    {
        private string _Id;
        private string _Name;
        private DateTime _Birday;
        private string _Phone;
        private string _Gender;
        private string _Email;

        public Customer()
        {

        }

        public Customer(string id, string name, DateTime birday, string phone, string gender, string email)
        {
            Id = id;
            Name = name;
            Birday = birday;
            Phone = phone;
            Gender = gender;
            Email = email;
        }

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime Birday { get => _Birday; set => _Birday = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
