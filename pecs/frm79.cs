using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pecs.state;

namespace pecs
{
    public partial class frm79 : Form
    {
        public FormName ch = FormName.None;

        public frm79()
        {
            InitializeComponent();
        }

        private void frm79_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Topic.Topic78State.chosenImage;
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var res = Topic.Topic78State.regList.Find(v => v == btn.Text);
            if (res == null)
            {
                ch = FormName.FRM80;
            }
            else
            {
                ch = FormName.FRM81;
            }

            Topic.Topic78State.T = btn.Text;
            Topic.Topic78State.T2 = "";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_ans2_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var res = Topic.Topic78State.regList.Find(v => v == btn.Text);
            if (res == null)
            {
                ch = FormName.FRM86;
            }
            else
            {
                ch = FormName.FRM87;
            }

            Topic.Topic78State.T = "";
            Topic.Topic78State.T2 = btn.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}