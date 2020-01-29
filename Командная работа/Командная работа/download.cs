using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Командная_работа
{
    public partial class download : Form
    {
        public download()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] array;
            using (System.IO.StreamReader read = new System.IO.StreamReader(@"C:\КОЛЛЕДЖ\team.txt"))
            {

                array = read.ReadToEnd().Split(new Char[] { ' ', '\r' });
                int pos = 0;
                for (int i = 0; i < 10; i++) //Где 4 - кол-во столбцов
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (array[pos] != "")
                            dataGridView1[j, i].Value = array[pos];
                        pos++;
                    }
                }
            }
        }
        private void download_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new Form1();
            f.Show();
        }

        private void download_Load(object sender, EventArgs e)
        {
            int n = 10;
            for (int i = 0; i < n - 1; i++)
            {
                this.dataGridView1.Rows.Add("", "");

            }
        }
    }
}
