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
    public partial class frm13 : Form
    {
        public FormName ch = FormName.None;
        public frm13()
        {
            InitializeComponent();
            pictureBox1.Image = Topic13State.chosenImage;
        }

        private void frm13_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM12;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            CurrentState.correctNum++;
            if (CurrentState.correctNum >= FourthStep.correctNum)
            {
                ch = FormName.FRM16;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM14;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM15;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
