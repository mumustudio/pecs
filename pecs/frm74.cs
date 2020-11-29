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
    public partial class frm74 : Form
    {
        public FormName ch = FormName.None;
        public frm74()
        {
            InitializeComponent();
        }

        private void frm74_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.advancedPickedImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            Goal.CurrentState.correctNum++;
            if (Goal.CurrentState.correctNum >= Goal.SixthStep.correctNum)
            {
                ch = FormName.FRM77;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM75;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM76;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM73;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
