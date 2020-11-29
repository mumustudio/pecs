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
    public partial class frm15 : Form
    {
        public FormName ch = FormName.None;
        public frm15()
        {
            InitializeComponent();
            pictureBox1.Image = Topic13State.chosenImage;
        }

        private void frm15_Load(object sender, EventArgs e)
        {

        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM13;
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
