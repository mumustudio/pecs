using pecs.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pecs
{
    public partial class frm1 : Form
    {
        public FormName ch = FormName.None;
        public string stuName, stuPwd, leader, leadername;
        public bool LoginAction = true;

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        public frm1()
        {
            InitializeComponent();
            stuName = "";
            stuPwd = "";
            leader = "";
            leadername = "";
            this.Location = new Point(800, 400);
        }

        private void reg_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == "") || (txtpasswd.Text == ""))
            {
                MessageBox.Show("請輸入帳號 , 密碼後才能新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (txtName.Text == "") txtName.Focus();
                else txtpasswd.Focus();
            }
            else
            {
                stuName = txtName.Text;
                stuPwd = txtpasswd.Text;

                if (PecsDB.CheckDataExist("StudentInfo", "StudentName", stuName))
                {
                    MessageBox.Show("帳號已存在 , 無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    ch = FormName.Register;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            stuName = txtName.Text;
            stuPwd = txtpasswd.Text;
            leadername = txtLeaderName.Text;
            if (radioButton1.Checked) leader = "教師";
            if (radioButton2.Checked) leader = "家長";
            bool isSuccess;
            DateTime now = DateTime.Now;

            isSuccess = PecsDB.Login(stuName, stuPwd, leader, leadername, now);
            if (isSuccess)
            {
                ch = FormName.LoginPass;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號未註冊 , 無法登入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //stuName = txtName.Text;
            //stuPwd = txtpasswd.Text;
            //leadername = txtLeaderName.Text;
            //if ((stuName == "") || (stuPwd == "") || (leadername == "")) MessageBox.Show("請輸入帳號 , 密碼 , 指導者後才能登入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //else
            //{
            //    if (radioButton1.Checked) leader = "teacher";
            //    else leader = "parent";
            //    if (pecsDB.Status != PECSDBSTATUS.DB_CONNECTED) MessageBox.Show("資料庫未連線, 無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    else
            //    {
            //        string s = "select passdword from user_info where username=N'" + stuName.Trim() + "'";
            //        if (stuPwd.Trim() != pecsDB.QueryPassword(s)) ch = FormName.LoginFail;
            //        else
            //        {
            //            s = "insert into login_record (username,passdword,leader,logintime) values ";
            //            s += string.Format("(N'{0}',N'{1}',N'{2}','{3}')", stuName, stuPwd, txtLeaderName.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //            pecsDB.ExecuteNonQuery(s);
            //            //pecsDB.DisConnect();
            //            //pecsDB.Connect();
            //            ch = FormName.LoginPass;

            //        }
            //        this.DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //}

        }
    }
}
