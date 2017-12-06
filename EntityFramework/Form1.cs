using System;
using System.Data.Entity;
using EntityFramework.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            DataBaseContext oDataBaseContext = new DataBaseContext();

            listBox1.DataSource = oDataBaseContext.Countries.ToList();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Displayn";
            dataGridView1.DataSource = oDataBaseContext.Countries.ToList();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DataBaseContext oDataBaseContext = null;
            try
            {
                oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country()
                {
                    Name = txt2.Text.Trim(),
                    Code = Convert.ToInt32(txt1.Text),
                };
                oDataBaseContext.Countries.Add(oCountry);

                oDataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oDataBaseContext != null)
                {
                    oDataBaseContext.Dispose();
                    oDataBaseContext = null;
                }
                txt1.Text = "";
                txt2.Text = "";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
