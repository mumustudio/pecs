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
    public partial class frm4 : Form
    {
        public FormName ch = FormName.None;
        public bool LoginAction = false;

        public frm4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = txtName.Text.Trim();
            student.birthYear = txtYear.Text;
            student.birthMon = comboBox_month.SelectedIndex.ToString();
            if (comboBox_sex.SelectedIndex == 0)
            {
                student.sex = "男";
            }
            else
            {
                student.sex = "女";
            }

            if (class1.Checked) student.className = "普通班";
            else if (class2.Checked) student.className = "資源班";
            else if (class3.Checked) student.className = "特教班";
            else if (class4.Checked) student.className = "特殊學校";
            else if (class5.Checked) student.className = textBox_className.Text.Trim();

            string reqStr = "";
            if (require1.Checked) reqStr = reqStr + "自閉症 ";
            if (require2.Checked) reqStr = reqStr + "智能障礙 ";
            if (require3.Checked) reqStr = reqStr + textBox_req.Text.Trim();
            student.require = reqStr;

            PecsDB.RegStu(student);

            frm5 frs = new frm5(student.name);
            var dialogResult = frs.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                ch = FormName.Login;
                this.Close();
            }
            else if (DialogResult.Cancel == dialogResult)
            {

            }
            else
            {
                MessageBox.Show("資料輸入有誤, 無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            comboBox_sex.SelectedIndex = 0;
            comboBox_month.SelectedIndex = DateTime.Now.Month - 1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            class5.Checked = true;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
