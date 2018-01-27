using System;
using Casting.Models;
using System.Linq;
using System.Windows.Forms;

namespace Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataBaseContext MyDataBaseContext { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //نیو نمودن شی دیتا بیس کانتکست
                MyDataBaseContext =
                    new DataBaseContext();

                // ایجاد یک متغیر از جنس ور که حاوی کشور هاست
                var varCountries =
                    MyDataBaseContext.Countreis
                    .ToList()
                    ;
                //تنظیمات لیست کانتری
                lstCountry.ValueMember = "ID";
                lstCountry.DisplayMember = "Namee";
                //کشور ها به لیست بایند میشود
                lstCountry.DataSource = varCountries;
            }
            //در صورت بروز خطا آن را نمایش میدهیم
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ایجاد یک شی از کانتری که حاوی  آیتم های لیست که کانتری هستند هست 
            //حرفه ای ترین شکل کستینگ
            //معنی آن یعنی اگر لیست آیتم نداشت شی کانتری نال است اگر آیتم داشت کانتری نبود باز هم نال است در غیر اینصورت شی کانتری حاوی آیتم های لیست میباشد
            Country oCountry =
                lstCountry.SelectedItem as Country;

            if (oCountry != null)
            {
                //تنظیمات لیست
                lstState.ValueMember = "ID";
                lstState.DisplayMember = "Name";
                //لیست استان ها بایند میشود با پراپرتی استان شی کشور
                lstState.DataSource = oCountry.States;
            }
        }

        private void lstState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ایونت فرم کلوزد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed
            (object sender, FormClosedEventArgs e)
        {
            if (MyDataBaseContext != null)
            {
                MyDataBaseContext.Dispose();
                MyDataBaseContext = null;
            }
        }
    }
}
