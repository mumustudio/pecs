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
using static pecs.state.Goal;
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm24 : Form
    {
        public FormName ch = FormName.None;
        public frm24()
        {
            InitializeComponent();
        }

        private void frm24_Load(object sender, EventArgs e)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM23;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            CurrentState.correctNum++;
            if (CurrentState.correctNum >= FifthStep.correctNum)
            {
                ch = FormName.FRM27;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM25;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM26;
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
