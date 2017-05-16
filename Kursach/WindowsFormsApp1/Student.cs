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

      
        protected string number;
        protected string group;
        protected string kodspec;
        public string rabota;



        protected Student(string number, string group, string kodspec, string rabota)
        {
            this.number = number;
            this.group = group;
            this.kodspec = kodspec;
            this.rabota = rabota;


        }

        public void Setter(string qq)
        {
            rabota = qq;
        }



        ~Student()
        {
            MessageBox.Show("Объект удален");
        }



        


    }
    }
