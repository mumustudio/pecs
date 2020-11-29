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
    public partial class frm77 : Form
    {
        public FormName ch = FormName.None;
        public frm77()
        {
            InitializeComponent();
        }

        private void frm77_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM73;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
