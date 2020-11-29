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
    public partial class frm5 : Form
    {
        public FormName ch = FormName.None;
        private string studentName;
        public frm5(String studentName)
        {
            InitializeComponent();
            this.studentName = studentName;
        }

        private void frmRegisterSuccess_Load(object sender, EventArgs e)
        {
            Student student= PecsDB.GetStu(studentName);
            int i;
            string s = "";
            ListViewItem i1 = new ListViewItem(studentName);
            i1.BackColor = Color.LawnGreen;  
            i1.SubItems.Add(student.sex);
            i = Convert.ToInt32(student.birthYear);
            s = i.ToString("000");
            i1.SubItems.Add(s);
            i = Convert.ToInt32(student.birthMon);
            i++;
            s = i.ToString("00");
            i1.SubItems.Add(s);           
            i1.SubItems.Add(student.className);
            i1.SubItems.Add(student.require);
            i1.SubItems.Add(student.memo);
            listView1.Items.Add(i1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (pecsDB.Status != PECSDBSTATUS.DB_CONNECTED) MessageBox.Show("資料庫未連線, 無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //else
            //{

            //    string s = "insert into user_info  (username, passdword, b_year, b_month, sex, class_item, class_remarks, special_case_item, special_case_remarks) values (";
            //    s += string.Format("N'{0}','{1}',{2},{3},N'{4}',{5},N'{6}',{7},N'{8}')",
            //        insdata[0], insdata[1], insdata[2], insdata[3], insdata[4], insdata[5], insdata[6], insdata[7], insdata[8]);
            //    if (pecsDB.ExecuteNonQuery(s))
            //    {
            //        ch = FormName.RegisterSuccess;
            //        this.DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("資料輸入有誤, 無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PecsDB.DelStu(studentName);
            ch = FormName.Register;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
