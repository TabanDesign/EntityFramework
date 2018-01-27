using System;
using RelationManyToMany.Models;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RelationManyToMany
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
        /// <summary>
        /// در این کلاس چند یوزر و چند گروه به دیتا بیس میدهیم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRecords_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                Group group = null;
                for (int i = 1; i <= 3; i++)
                {
                    group = new Group
                    {
                        Name = $"group {i}"
                    };
                    dataBaseContext.Groups.Add(group);
                }

                User user = null;
                for (int i = 1; i <= 7; i++)
                {
                    user = new User
                    {
                        Name = $"user {i}"
                    };
                    dataBaseContext.Users.Add(user);
                }

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
        /// <summary>
        /// در این کلاس چند یوزر به طول مشترک در یک گروه میروند
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUsersToGroup_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();
                ///نکته : برای یافتن یک داده از دیتابیس و بیرون اوردن آن لازم نیس آن را نیو کنیم
                ///ابتدا گروهی که یوزر ها میخاهند در ان بروند را بیرون میاوریم
                Group groupCommom = dataBaseContext.Groups.Where(c => c.Name == "group 2").FirstOrDefault();
                ///سپس یوزر هایی که در ان گروه میروند را بیرون میاوریم
                User user1 = dataBaseContext.Users.Where(c => c.Name == "user 2").FirstOrDefault();
                User user2 = dataBaseContext.Users.Where(c => c.Name == "user 4").FirstOrDefault();
                User user3 = dataBaseContext.Users.Where(c => c.Name == "user 6").FirstOrDefault();
                ///سپس نام آن گروهی که گروهه بیرون آمده در ان است را به پراپرتی یوزر ان اضافه میکنیم
                groupCommom.Users.Add(user1);
                groupCommom.Users.Add(user2);
                groupCommom.Users.Add(user3);
                ///سیو دیتابیس
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
        /// <summary>
        /// همانند بالا
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGroupsToUser_Click(object sender, EventArgs e)
        {
            DataBaseContext dataBaseContext = null;
            try
            {
                dataBaseContext = new DataBaseContext();

                User userActive = dataBaseContext.Users.Where(c => c.Name == "user 1").FirstOrDefault();

                Group group1 = dataBaseContext.Groups.Where(c => c.Name == "group 1").FirstOrDefault();
                Group group2 = dataBaseContext.Groups.Where(c => c.Name == "group 2").FirstOrDefault();
                Group group3 = dataBaseContext.Groups.Where(c => c.Name == "group 3").FirstOrDefault();

                userActive.Groups.Add(group1);
                userActive.Groups.Add(group2);
                userActive.Groups.Add(group3);

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
