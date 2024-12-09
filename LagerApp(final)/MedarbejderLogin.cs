using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class MedarbejderLogin
    {
        public string MedarbejderID { get; set; }
        public string Password { get; set; }

        public MedarbejderLogin(string medarbejderID, string password)
        {
            MedarbejderID = medarbejderID;
            Password = password;
        }
    }
}
