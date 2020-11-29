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
    public partial class frm67 : Form
    {
        public FormName ch = FormName.None;
        public frm67()
        {
            InitializeComponent();
        }

        private void frm67_Load(object sender, EventArgs e)
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
            ch = FormName.FRM63;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
