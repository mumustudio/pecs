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

namespace pecs
{
    public partial class frm6 : Form
    {
        public FormName ch = FormName.None;
        public frm6()
        {
            InitializeComponent();
            Topic.topicForm = FormName.FRM6;
        }

        private void frm6_Load(object sender, EventArgs e)
        {
            CurrentState.correctNum = 0;
            Topic.Topic22State.T = "";
            Topic.Topic22State.T2 = "";
            Topic.Topic43State.T = "";
            Topic.Topic43State.T2 = "";
            Topic.Topic78State.T = "";
            Topic.Topic78State.T2 = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ch = FormName.Login;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ch = FormName.FRM12;
            else if (radioButton2.Checked) ch = FormName.FRM22;
            else if (radioButton3.Checked) ch = FormName.FRM43;
            else if (radioButton4.Checked) ch = FormName.FRM78;
            if (ch != FormName.None)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ch = FormName.FRM17;
            else if (radioButton2.Checked) ch = FormName.FRM28;
            else if (radioButton3.Checked) ch = FormName.FRM46;
            else if (radioButton4.Checked) ch = FormName.FRM78;
            if (ch != FormName.None)
            {
                if (!radioButton4.Checked && !radioButton3.Checked)
                {
                    Topic.advancedNextFormName = ch;
                    ch = FormName.PickImage;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM7;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
