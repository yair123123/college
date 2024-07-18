
using EmployeeClock;
using Guest_Shabbat_Host_App.DAL;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;



namespace college
{

    public partial class login : Form

    {
        public static bool check = false;
        DBContext db = new DBContext(DBContext.GetConnString("secrets.json", "connecction"));
        public login()
        {
            check = false;
            InitializeComponent();
            EnterToCombo();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            int a = db.ExecuteNonQuery("insert into lids values (@name,@phone,@interest)", [new SqlParameter("@name", textBox_name.Text), new SqlParameter("@phone", textBox_phone.Text), new SqlParameter("@interest", comboBox1.Text)]);
            if (a > 0)
            {
                MessageBox.Show("נרשמת בהצלחה נציגינו יחזור אליך בהקדם!");
                Application.Exit();
            }
            else { MessageBox.Show("חלה שגיאה יש לנסות שנית מאוחר יותר!"); }
        }
        private void button_enter_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("הכנס סיסמא(1234)");
            if (a == "1234")
            {
                FromHandler.ShowFrom("lids");
            }
            else { MessageBox.Show("אינך מאושר!"); }
        }
        private void EnterToCombo()
        {
            DataTable dt = db.ExecuteQuery("select CoursName from courses");
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["CoursName"].ToString());
            }
        }
        public static void stop_application(object sender, EventArgs e)
        {
            if (!check)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("הכנס את שמך");
            object check = db.ExecuteScalar("if not exists (select * from Students where StudentName = @a)\r\nbegin \r\nselect 1\r\nend\r\nelse\r\nbegin \r\nselect 0\r\nend",new SqlParameter("@a",a));
            if (int.Parse(check.ToString()) == 1) { MessageBox.Show("אינך קיים במערכת!"); }
            else { FromHandler.ShowFrom("Student",a); }
            
        }
    }
}