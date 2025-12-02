using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaControl.Data
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // možeš kasnije šifrirati
        public override string ToString()
        {
            return $"{Username}";
        }
    }
}
