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
    public partial class frm43 : Form
    {
        public FormName ch = FormName.None;
        public frm43()
        {
            InitializeComponent();
        }

        private void frm43_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Topic43State.T = btn.Text;
            Topic43State.T2 = "";
            Topic43State.totalQuestion = "你" + btn.Text + "什麼?";
            ch = FormName.FRM44;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Click2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Topic43State.T = "";
            Topic43State.T2 = btn.Text;
            Topic43State.totalQuestion = btn.Text + "什麼?";
            ch = FormName.FRM56;
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
