using System;
using System.Data.Entity;
using System.Windows.Forms;
using Seed.Models;

namespace Seed
{
    public partial class Form1 : Form
    {
        #region form1()
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region form1_load()
        /// <summary>
        /// ادد و نمایش برنامه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                //Person person = new Person("mohammad", "saeid", "nazari");
                //dataBaseContext.People.Add(person);
                dataBaseContext.SaveChanges();

                dataBaseContext.People.Load();

                lstPeople.ValueMember = "ID";
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
        #endregion
    }
}
