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
    }
}
