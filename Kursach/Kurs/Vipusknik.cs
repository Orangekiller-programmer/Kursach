using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Vipusknik : Student
    {

        

        public Vipusknik(string number, string group, string kodspec, string rabota)
            : base(number, group, kodspec, rabota)


        {
           
       }

        public string geter()

        {
            string vosvrat = "    " + number + "    " + kodspec + "    " + rabota;
            return vosvrat;
        }

    }
}
