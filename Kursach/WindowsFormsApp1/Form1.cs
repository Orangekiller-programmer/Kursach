using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Rabotaushiy> stud = new List <Rabotaushiy>();
       



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(maskedTextBox2.Text)) || (String.IsNullOrWhiteSpace(maskedTextBox3.Text)) || (String.IsNullOrWhiteSpace(textBox4.Text)) ||  (String.IsNullOrWhiteSpace(maskedTextBox1.Text)))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView2.Clear();

            
           
            stud.Add(new Rabotaushiy(maskedTextBox2.Text, maskedTextBox1.Text, maskedTextBox3.Text, textBox4.Text));
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            textBox4.Clear();



            for (int a = 0; a < stud.Count; a++)
            {
                listView1.Items.Add(stud[a].geter());
                listView2.Items.Add(stud[a].Group);

            }



        }
        private void button3_Click(object sender, EventArgs e)


        {
            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int num = listView1.SelectedIndices[0];
                stud.RemoveAt(num);
                listView1.Items[num].Remove();
                listView2.Items[num].Remove();

            }
            foreach(ListViewItem item in listView2.SelectedItems)
            {
                int num = listView2.SelectedIndices[0];
                stud.RemoveAt(num);
                listView1.Items[num].Remove();
                listView2.Items[num].Remove();



                }

            }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                
                int num = listView1.SelectedIndices[0];
                stud[num].Setter(textBox4.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView2.Clear();

            for (int a = 0; a < stud.Count; a++)
            {
                listView1.Items.Add(stud[a].geter());
                listView2.Items.Add(stud[a].Group);

            }

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].rabota == textBox1.Text)
                {
                    listView1.Clear();
                    listView2.Clear();
                    listView1.Items.Add(stud[i].geter());
                    listView2.Items.Add(stud[i].Group);

                }

                if (stud[i].Group ==textBox1.Text)
                        {

                    listView1.Clear();
                    listView2.Clear();
                    listView1.Items.Add(stud[i].geter());
                    listView2.Items.Add(stud[i].Group);

                }
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
