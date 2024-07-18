using EmployeeClock;
using Guest_Shabbat_Host_App.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class lids : Form
    {
        DBContext db = new DBContext(DBContext.GetConnString("secrets.json","connecction"));
        string lid;
        public lids()
        {
            InitializeComponent();
            FillList();
        }
        private void FillList()
        {
            DataTable dt = db.ExecuteQuery("Select name from lids");
            foreach (DataRow item in dt.Rows)
            {
                listBox.Items.Add(item["Name"].ToString());
            }
        }
        private void NameLid(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                lid = listBox.SelectedItem.ToString();
                db.ExecuteNonQuery("delete from lids where name = @name",new SqlParameter("@name", lid));
                FromHandler.ShowFrom("courses", lid);
            }
            else
            {
                MessageBox.Show("אנא בחר מתוך הרשימה");
            }
        }
    }

}
