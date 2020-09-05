using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker_pokusaj_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password.Text==Properties.Settings.Default.password) //Provjeravam da li je text u boxu password jednak onome u prop
            {
                MainForm_3cs mainForm = new MainForm_3cs();
                mainForm.Show(); //prikazi glavnu formu
                this.Hide(); //sakrij login formu 
            }
            else
            {
                MessageBox.Show("Wrong password! Try again.");
            }
        }
    }
}
