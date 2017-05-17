using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Student
    {

      
        public string number;
        public string group;
        public string kodspec;
        public string rabota;



        public Student(string number, string group, string kodspec, string rabota)
        {
            this.number = number;
            this.group = group;
            this.kodspec = kodspec;
            this.rabota = rabota;
            

        }
        public Student()
        { }

        public void Setter(string qq)
        {
            rabota = qq;
        }

     

       

        public string getter ()
        {
            string stroka = number + "  " + group + "  " + kodspec + "  " + rabota;
            return stroka;
        }

        


    }
    }

