using System;
using Migration.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migration
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
                Person person = null;
                person = new Person()
                {
                    Name = "ایران",
                    Population = "زیاد"
                };
                dataBaseContext.Persons.Add(person);
                person = new Person
                {
                    Name = "جیبوتی",
                    Population = "کم"
                };
                dataBaseContext.Persons.Add(person);
                dataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataBaseContext!=null)
                {
                    dataBaseContext.Dispose();
                    dataBaseContext = null;
                }
            }
        }
    }
}
