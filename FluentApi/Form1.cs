using System;
using System.Data.Entity;
using FluentApi.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Country country = null;
                country = new Country()
                {
                    ID = 1,
                    Name = "ایران"
                };
                dataBaseContext.Countries.Add(country);

                country = new Country()
                {
                    ID = 2,
                    Name = "عراق"
                };
                dataBaseContext.Countries.Add(country);

                country = new Country()
                {
                    ID = 3,
                    Name = "سوریه"
                };
                dataBaseContext.Countries.Add(country);

                dataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataBaseContext != null)
                {
                    dataBaseContext.Dispose();
                    dataBaseContext = null;
                }
            }
        }
    }
}
