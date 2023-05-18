using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Toking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

      

      

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("massage", typeof(String));
            DataGridView.DataSource = table;

            DataGridView.Columns["Massage"].Visible = false;
         
        }

        private void bttnew_Click(object sender, EventArgs e)
        {
            texttital.Clear();
            textmassage.Clear();
        }

        private void bttsave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(texttital.Text,textmassage.Text);

            texttital.Clear();
            textmassage.Clear();
        }

        private void bttread_Click(object sender, EventArgs e)
        {
            int index = DataGridView.CurrentCell.RowIndex;

            if(index > -1)
            {
                texttital.Text = table.Rows[index].ItemArray[0].ToString();  
                textmassage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttdelete_Click(object sender, EventArgs e)
        {
            int index = DataGridView.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
