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
    public partial class MainForm_3cs : Form
    {
        public MainForm_3cs()
        {
            InitializeComponent();
        }

        private void addTr_Click(object sender, EventArgs e)
        {
            decimal TransValue =Convert.ToDecimal( value.Text);
            string TranDes = description.Text;
            DateTime TransDate = dateTimePicker1.Value;
            
            int TransType = 0;

            if(pay.Checked)
            {
                TransType = 0;
            }
            if(income.Checked)
            {
                TransType = 1;
            }

            DataSet1TableAdapters.MoneyTracker_tableTableAdapter MyAdapter= new DataSet1TableAdapters.MoneyTracker_tableTableAdapter();
            MyAdapter.InsertTransaction(TransValue, TranDes, TransDate, Convert.ToBoolean(TransType));
            MessageBox.Show("Well done!", "Money Tracker");
            this.moneyTracker_tableTableAdapter.Fill(this.dataSet1.MoneyTracker_table);

            value.Text = "";
            description.Text = "";
            pay.Checked = true;
        }


        private void MainForm_3cs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MoneyTracker_table' table. You can move, or remove it, as needed.
            this.moneyTracker_tableTableAdapter.Fill(this.dataSet1.MoneyTracker_table);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            moneyTracker_tableTableAdapter.Update(dataSet1);
            dataGridView1.EndEdit();
            this.moneyTracker_tableTableAdapter.Fill(this.dataSet1.MoneyTracker_table); //update view
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
