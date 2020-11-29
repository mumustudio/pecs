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
using static pecs.state.Goal;

namespace pecs
{
    public partial class frm50 : Form
    {
        public FormName ch = FormName.None;
        public frm50()
        {
            InitializeComponent();
        }
        private void frm50_Load(object sender, EventArgs e)
        {
            CurrentState.correctNum = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM46;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
