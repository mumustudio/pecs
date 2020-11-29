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
    public partial class frm14 : Form
    {
        public FormName ch = FormName.None;
        public frm14()
        {
            InitializeComponent();
            pictureBox1.Image = Topic13State.chosenImage;
        }

        private void frm14_Load(object sender, EventArgs e)
        {

        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM12;
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
