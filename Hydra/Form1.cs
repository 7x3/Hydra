using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
//using Microsoft.Toolkit.Uwp.Notifications;


namespace Hydra
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = true;
            this.Hide();
            Form NewForm = new Form1();
            NewForm.Show();
            Form NewForm2 = new Form1();
            NewForm2.Show();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

    }
}
