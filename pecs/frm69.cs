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
    public partial class frm69 : Form
    {
        public FormName ch = FormName.None;
        public frm69()
        {
            InitializeComponent();
        }

        private void frm69_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.Topic68State.chosenImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM68;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            Goal.CurrentState.correctNum++;
            if (Goal.CurrentState.correctNum >= Goal.SixthStep.correctNum)
            {
                ch = FormName.FRM72;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM70;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM71;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
