using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm1
{
    internal class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public User(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Password: {Address}, email: {Email}";
        }
    }
}
