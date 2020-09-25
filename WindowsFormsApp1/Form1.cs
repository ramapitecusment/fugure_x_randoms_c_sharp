using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int size;
        int k, l, m, n;
        Random rnd = new Random();

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox1.Text);
            setRandomNumbers(size);
            setValues(size);


        }

        private void setValues(int size)
        {
            k = size;
            for (int j = 0; j < (size + 1) / 2; j++)
            {
                for (int i = j; i < k; i++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "0";
                }
                k--;
            }
            k = -1;
            for (int j = size - 1; j >= ((size + 1) / 2) - 1; j--)
            {
                for (int i = j; i > k; i--)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "0";
                }
                k++;
            }
        }

        private void setRandomNumbers(int size)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
            dataGridView1.ColumnCount = size;
            dataGridView1.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(0, 99);
                }
            }
        }

    }
}
