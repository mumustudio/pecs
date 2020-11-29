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
    public partial class frm47 : Form
    {
        public FormName ch = FormName.None;
        public frm47()
        {
            InitializeComponent();
        }

        private void frm47_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic43State.chosenImage;
            // label2.Text = Topic43State.totalQuestion;
            // if (Topic43State.T != "")
            // {
            //     label3.Text = "我" + Topic43State.T;
            // }
            // else if (Topic43State.T2 != "")
            // {
            //     label3.Text = Topic43State.T;
            // }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM46;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            CurrentState.correctNum++;
            if (CurrentState.correctNum >= FifthStep.correctNum)
            {
                ch = FormName.FRM50;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM48;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM49;
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
