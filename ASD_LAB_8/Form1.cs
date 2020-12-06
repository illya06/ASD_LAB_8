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

        private void button1_Click(object sender, EventArgs e)
        {
            string positions = "";
            string logOut = "";
            int i = 0;

            list.Clear();

            for(int j = 10; j <= 20; j++)
            {
                list.Add(j);
            }

            listToLog(list);
            foreach(int val in list)
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
            int[] n = { 10, 20, 200, 2000, 20000 };
            int[,] output = new int[2,5];
            int step = 0;

            dataGridView1.Rows.Clear();

            if (rand.Checked)
                foreach (int val in n)
                {
                    Random rand_ = new Random();
                    list.Clear();
                    for(int i = 1; i <= val; i++)
                    {
                        list.Add(rand_.Next(1, val));
                    }

                    int amm = 0;
                    int res = -1;

                    foreach (int num in list)
                    {
                        amm++;
                        if (num == Convert.ToInt32(seekVal.Text))
                        {
                            res = num;
                            output[0, step] = res;
                            output[1, step] = amm;
                        }
                    }

                    step++;
                }
            else if (lin.Checked)
                foreach (int val in n)
                {
                    list.Clear();
                    for (int i = 1; i <= val; i++)
                    {
                        list.Add(i);
                    }

                    int amm = 0;
                    int res = -1;
                    foreach(int num in list)
                    {
                        amm++;
                        if(num == Convert.ToInt32(seekVal.Text))
                        {
                            res = num;
                            output[0, step] = res;
                            output[1, step] = amm;
                        }
                    }
                    step++;
                }

            for (int i = 0; i < 2; i++)
                dataGridView1.Rows.Add(output[i, 0], output[i, 1], output[i, 2], output[i, 3], output[i, 4]);
        }
    }
}
