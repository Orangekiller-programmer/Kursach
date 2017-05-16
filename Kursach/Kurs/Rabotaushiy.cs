using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class Rabotaushiy : Vipusknik
    {
        public Rabotaushiy(string number,string group, string kodspec, string rabota)
            : base(number, group, kodspec, rabota)
            { }




        public string Group
        {
            get
            {

                return group;

            }

            set
            {
                group = value;
            }


        }

        }




    }


