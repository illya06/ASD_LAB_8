using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD_LAB_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLES
        List<int> list = new List<int>();
        //__________________

        void listToLog(List<int> list_)
        {
            log.Text = "\nList content : \n";
            foreach(int var in list_)
            {
                log.Text += $" {var} ";
            }
            log.Text += "\n";
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random rand_ = new Random();
            int n = Convert.ToInt32(size.Text);
            if (rand.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    list.Add(rand_.Next(10, 20));
                }
            }
            else if (lin.Checked)
            {
                if(n >= 10)
                for(int i = 10; i <= n; i++)
                {
                    list.Add(i);
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list_ = new List<int>();
            string positions = "";
            string logOut = "";
            int i = 0;


            for (int j = 10; j <= 20; j++)
            {
                list_.Add(j);
            }

            listToLog(list_);
            foreach(int val in list_)
            {
                logOut += $"\nChecked if {val}%10 == 3";
                if (val % 10 == 3)
                {
                    logOut += " (true)";
                    positions += $"id({i})  ";
                }
                else
                {
                    logOut += " (false)";
                }
                i++;
            }
            result.Text = positions;
            log.Text += logOut;
        }

        private void tableSart_Click(object sender, EventArgs e)
        {

        }
    }
}
