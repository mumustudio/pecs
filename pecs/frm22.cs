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
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm22 : Form
    {
        public FormName ch = FormName.None;
        public frm22()
        {
            InitializeComponent();
        }

        private void frm22_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Topic22State.T = btn.Text;
            Topic22State.T2 = "";
            Topic22State.totalQuestion = "你" + btn.Text + "什麼?";
            ch = FormName.FRM23;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Click2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Topic22State.T = "";
            Topic22State.T2 = btn.Text;
            Topic22State.totalQuestion = btn.Text + "什麼?";
            ch = FormName.FRM33;
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
