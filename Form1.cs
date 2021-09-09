using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 245;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            tTxtBox.Clear();
            mTxtBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(tTxtBox.Text, mTxtBox.Text);
            tTxtBox.Clear();
            mTxtBox.Clear();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                tTxtBox.Text = table.Rows[index].ItemArray[0].ToString();
                mTxtBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
