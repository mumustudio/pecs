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
    public partial class frm70 : Form
    {
        public FormName ch = FormName.None;
        public frm70()
        {
            InitializeComponent();
        }

        private void frm70_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.Topic68State.chosenImage;
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM69;
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
