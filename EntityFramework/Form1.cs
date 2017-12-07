using System;
using System.IO;
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

        #region Form1()
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Form1_Load(object sender, EventArgs e)
        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
            EmptyTXT();
        }
        #endregion
        #region Display()
        public void Display()
        {
            try
            {
                DataBaseContext oDataBaseContext = new DataBaseContext();
                oDataBaseContext.Countries.OrderBy(c => c.Code).Load();
                listBox1.DataSource = oDataBaseContext.Countries.Local;
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "Displayn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region btn1_Click(object sender, EventArgs e)
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
                oCountry.More = new MoreDetails();
                if (txt3.Text != "")
                {
                    oCountry.More.Area = Convert.ToInt32(txt3.Text);
                }
                if (txt4.Text != "")
                {
                    oCountry.More.Population = Convert.ToInt32(txt4.Text);
                }

                oDataBaseContext.Countries.Add(oCountry);

                //از این روش هم میشه ادد کرد
                //oDataBaseContext.Entry(oCountry).State = EntityState.Added;

                ///
                ///از این روش نمیشه استفاده کرد ک مستقیم باید از کانتری پر کنیم
                ///
                //MoreDetails oMoreDetails = new MoreDetails();
                //oMoreDetails.Area = Convert.ToInt32(txt3.Text);
                //oMoreDetails.Population = Convert.ToInt32(txt4.Text);

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
                EmptyTXT();
            }
        }
        #endregion btn1_Click
        #region btn2_Click(object sender, EventArgs e)
        private void btn2_Click(object sender, EventArgs e)
        {
            Display();
            EmptyTXT();
        }
        #endregion
        #region btn3_Click(object sender, EventArgs e)
        private void btn3_Click(object sender, EventArgs e)
        {
            DataBaseContext oDataBaseContext = null;
            try
            {
                oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country();

                int a = Convert.ToInt32(txt1.Text);
                oDataBaseContext.Countries.Where(c => c.Code == a).Load();
                oDataBaseContext.Countries.Local.Clear();

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
                EmptyTXT();
            }
        }
        #endregion
        #region btn4_Click(object sender, EventArgs e)
        private void btn4_Click(object sender, EventArgs e)
        {
            DataBaseContext oDataBaseContext = null;
            try
            {
                oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country();

                string a = txt2.Text;
                oDataBaseContext.Countries.Where(c => c.Name == a).Load();
                oDataBaseContext.Countries.Local.Clear();

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
                EmptyTXT();
            }
        }
        #endregion
        #region btn5_Click(object sender, EventArgs e)
        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseContext oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country();
                int a = Convert.ToInt32(txt1.Text);
                oDataBaseContext.Countries.Where(c => c.Code == a).Load();
                listBox1.DataSource = oDataBaseContext.Countries.Local;
                listBox1.DisplayMember = "Displayn";
                //for (int i = 0; i < o.Countries.Local.Count; i++)
                //{
                //    txt2.Text = txt2.Text + o.Countries.Local[i].Name+"  ";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EmptyTXT();
            }
        }
        #endregion
        #region EmptyTXT()
        public void EmptyTXT()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }
        #endregion
        #region btnRemoveAll_Click(object sender, EventArgs e)
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseContext oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country();
                oDataBaseContext.Countries.ToList();
                oDataBaseContext.Countries.Local.Clear();
                oDataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
