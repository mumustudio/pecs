using pecs.db;
using pecs.state;
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
    public partial class frm3 : Form
    {
        public FormName ch = FormName.None;
        public string stuName;

        public frm3(string studentName)
        {
            InitializeComponent();
            stuName = studentName;
        }

        private void frmLoginPass_Load(object sender, EventArgs e)
        {
            Student student = PecsDB.GetStu(stuName);
            int i;
            string s = "";
            ListViewItem i1 = new ListViewItem(stuName);
            i1.BackColor = Color.LawnGreen;
            s = Convert.ToInt32(student.birthYear).ToString("000") + (Convert.ToInt32(student.birthMon) + 1).ToString("00");
            i1.SubItems.Add(s);
            
            UserInfo userInfo = PecsDB.GetUser(stuName);
            if (userInfo.studentName != null)
            {
                i1.SubItems.Add(userInfo.leaderName);
                i1.SubItems.Add(userInfo.lastTime.ToString());
                listView1.Items.Add(i1);
            }
            //string s = "select TOP(1) * from login_record where username=N'" + uName + "' order by logintime desc";

            //ListViewItem i1 = new ListViewItem(info[0]);
            //i1.BackColor = Color.LawnGreen;
            //i1.SubItems.Add(info[1]);
            //i1.SubItems.Add(info[2]);
            //i1.SubItems.Add(info[3]);
            //listView1.Items.Add(i1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM7;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM6;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
