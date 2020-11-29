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
    public partial class frm19 : Form
    {
        public FormName ch = FormName.None;
        public frm19()
        {
            InitializeComponent();
        }

        private void frm19_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.advancedPickedImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM17;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
