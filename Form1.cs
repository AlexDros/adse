using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDoKiosk
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.Show();  
            this.Hide();

        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            Form2 proceed = new Form2();
            proceed.Show(); 
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
