using System;
using RelationOneToMany.Models;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RelationOneToMany
{
    public partial class Form1 : Form
    {
        #region Form1()
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Form1_Load()
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region BtnAddCountry_Click()
        /// <summary>
        /// در دکمه ی اول یک کشور با یک ایدی را به جدول کانتری اضافه میکنیم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddCountry_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Country country = null;
                country = new Country
                {
                    ID = 1,
                    Name = "iran"
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
        #endregion
        #region BtnDoSomthing_Click()
        /// <summary>
        /// توضیحات با دقت خوانده شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDoSomthing_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                ///ابتدا یک دیتابیس کانتکس نیو میکنیم
                dataBaseContext = new DataBaseContext();
                ///سپس یک کانتری میسازیم و کشوری که ایدی اش یک باشد را تویش میریزیم
                Country country = dataBaseContext.Countries.Where(c => c.ID == 1).FirstOrDefault();
                ///اگر همچین کانتری وجود نداشت از برنامه خارج میشود
                if (country == null)
                {
                    return;
                }
                State state = null;

                ///شهر اصفهان را به کشوری که جست و جو شده نسبت میدهد
                ///ایدی کشوری که جست و  جو شده را به ایدی شهر اصفهان میدهد
                state = new State();
                state.Name = "اصفهان";
                state.CountryId = country.ID;
                dataBaseContext.States.Add(state);

                ///کل کشوری که جست و جو شده را به قسمت کشوره استان اضافه میکند
                state = new State();
                state.Name = "تهران";
                state.Country = country;
                dataBaseContext.States.Add(state);

                ///در کلاس کانتری یک لیست استان داشتیم
                ///در ان لیست این شهر شیراز را ادد میکند
                state = new State();
                state.Name = "شیراز";
                country.States.Add(state);

                ///در اخر سیو میکنیم
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
        #endregion
    }
}
