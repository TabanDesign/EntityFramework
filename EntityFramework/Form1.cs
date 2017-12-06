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
            DataBaseContext oDataBaseContext = null;
            try
            {
                oDataBaseContext = new DataBaseContext();
                Country oCountry = new Country()
                {
                    Id = 1,
                    Name = "ایران",
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
            }
        }
    }
}
