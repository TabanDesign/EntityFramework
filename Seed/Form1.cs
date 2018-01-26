using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seed.Models;

namespace Seed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();

                Person person = new Person("mohammad", "saeid", "nazari");
                dataBaseContext.People.Add(person);
                dataBaseContext.SaveChanges();

                dataBaseContext.People.Load();

                lstPeople.ValueMember = "ss";
                lstPeople.DisplayMember = "DisplayFullName";
                lstPeople.DataSource = dataBaseContext.People.Local;

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
