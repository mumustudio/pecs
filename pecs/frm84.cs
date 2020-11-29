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
    public partial class frm84 : Form
    {
        public FormName ch = FormName.None;
        public frm84()
        {
            InitializeComponent();
        }

        private void frm84_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.Topic78State.chosenImage;
            label6.Text = Topic.Topic78State.T;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM81;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
