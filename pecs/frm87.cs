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
    public partial class frm87 : Form
    {
        public FormName ch = FormName.None;
        public frm87()
        {
            InitializeComponent();
        }

        private void frm87_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Topic.Topic78State.chosenImage;
            label8.Text = Topic.Topic78State.T2;
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
            if (Goal.CurrentState.correctNum >= 5)
            {
                ch = FormName.FRM91;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM88;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM89;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM90;
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
