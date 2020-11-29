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
    public partial class frm81 : Form
    {
        public FormName ch = FormName.None;
        public frm81()
        {
            InitializeComponent();
        }

        private void frm81_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Topic.Topic78State.chosenImage;
            label2.Text = Topic.Topic78State.T;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM79;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            Goal.CurrentState.correctNum++;
            if (Goal.CurrentState.correctNum >= Goal.FifthStep.correctNum)
            {
                ch = FormName.FRM85;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM82;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM83;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM84;
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
