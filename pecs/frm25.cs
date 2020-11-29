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
    public partial class frm25 : Form
    {
        public FormName ch = FormName.None;
        public frm25()
        {
            InitializeComponent();
        }
        private void frm25_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic22State.chosenImage;
            label2.Text = Topic22State.totalQuestion;
            if (Topic22State.T != "")
            {
                label3.Text = "我" + Topic22State.T;
            }
            else if (Topic22State.T2 != "")
            {
                label3.Text = Topic22State.T;
            }
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM23;
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
