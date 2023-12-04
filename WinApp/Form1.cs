using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace WinApp
{

   
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            TestClass test = new TestClass();

            lstShow.Items.Add(test.Print());
            lstShow.Items.Add(test.Print(txtFirstName.Text));
            lstShow.Items.Add(test.CalculateAge(Convert.ToDateTime(txtBornYear.Text)));
            lstShow.Size = new Size(100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TestClass tc = new TestClass();
            

            lblBornYear.Text = "Born Date";
            StaticMemebers.GetSize = lstShow.Size;
            lstShow.Items.Add("width " + lstShow.Width);
            lstShow.Items.Add("height " + lstShow.Height);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //TestClass tc = new TestClass();

            lstShow.Size = new Size(StaticMemebers.GetSize.Width, StaticMemebers.GetSize.Height);
            
        }
    }
}
