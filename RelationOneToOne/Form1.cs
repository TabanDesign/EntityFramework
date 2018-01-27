using System;
using System.Data.Entity;
using RelationOneToOne.Models;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RelationOneToOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddNewPeople_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Person person = null;
                ///ابتدا یک شخص را میسازیم و نامش را میگذاریم
                person = new Person
                {
                    FullName = "Mahdi Hajian"
                };
                ///سپس ان را ادد میکنیم
                dataBaseContext.Persons.Add(person);

                ///این دفعه شخص دیگری را میسازیم ولی ادرس هم بهش میدهیم
                person = new Person
                {
                    FullName = "ali ramazani"
                };
                Addess addess = null;
                addess = new Addess
                {
                    City = "shiraz",
                    State = "fars",
                    Country = "iran"
                };
                person.Addess = addess;
                dataBaseContext.Persons.Add(person);

                ///
                /// مثال پایین اشتباه است
                /// نمیشود مستقیم به ادرس اضافه کرد
                ///
                //person = new Person();                          
                //person.FullName = "saeid nazari";               
                //person.Addess.City = "اصفهان";                 
                //person.Addess.State = "استان اصفهان";         
                //person.Addess.Country = "ایران";                
                //dataBaseContext.Persons.Add(person);            

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

        private void BtnLoadAddressIncludePerson_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                dataBaseContext.Addresses.Include(c => c.Person).Where(c => c.Country.Contains("iran")).Load();
                var result_btn1 = dataBaseContext.Addresses.Local;
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

        private void BtnLoadPersonIncludeAddress_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                dataBaseContext.Persons.Include(c => c.Addess).Where(c => c.FullName.Contains("ramazani")).Load();
                var result_btn2 = dataBaseContext.Persons.Local;
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
