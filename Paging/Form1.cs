using System;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Paging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }

        private Models.DataBaseContext MyDatabaseContext { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            PageSize = 10;
            PageIndex = 1;

            try
            {
                MyDatabaseContext =
                    new Models.DataBaseContext();

                DisplayCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        private void DisplayCountries()
        {
            var varCountries =
                MyDatabaseContext.Countries
                .OrderBy(current => current.ID)
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList()
                ;

            lstCountries.ValueMember = "ID";
            lstCountries.DisplayMember = "Name";
            lstCountries.DataSource = varCountries;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyDatabaseContext != null)
            {
                MyDatabaseContext.Dispose();
                MyDatabaseContext = null;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (PageIndex >= 2)
            {
                PageIndex--;

                DisplayCountries();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex++;

            DisplayCountries();
        }

        private void lstCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
