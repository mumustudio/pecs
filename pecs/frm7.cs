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
using static pecs.state.Goal;

namespace pecs
{
    public partial class frm7 : Form
    {
        public FormName ch = FormName.None;

        public frm7()
        {
            InitializeComponent();
        }

        private void frmTech1_Load(object sender, EventArgs e)
        {
            CurrentState.correctNum = 0;
            Topic.topicForm = FormName.FRM7;
            Topic.advancedNextFormName = FormName.None;
            Topic.advancedPickedImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM8;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM11;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ch = FormName.FRM12;
            else if (radioButton2.Checked) ch = FormName.FRM22;
            else if (radioButton8.Checked) ch = FormName.FRM22;
            else if (radioButton7.Checked) ch = FormName.FRM44;
            else if (radioButton4.Checked) ch = FormName.FRM33;
            else if (radioButton6.Checked) ch = FormName.FRM56;
            else if (radioButton9.Checked) ch = FormName.FRM68;
            else if (radioButton10.Checked) ch = FormName.FRM78;
            if (ch != FormName.None)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ch = FormName.FRM17;
            else if (radioButton2.Checked) ch = FormName.FRM43;
            else if (radioButton8.Checked) ch = FormName.FRM28;
            else if (radioButton7.Checked) ch = FormName.FRM51;
            else if (radioButton4.Checked) ch = FormName.FRM38;
            else if (radioButton6.Checked) ch = FormName.FRM63;
            else if (radioButton9.Checked) ch = FormName.FRM73;
            else if (radioButton10.Checked) ch = FormName.FRM78;
            if (ch != FormName.None)
            {
                if (!radioButton10.Checked)
                {
                    Topic.advancedNextFormName = ch;
                    ch = FormName.PickImage;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ch = FormName.Login;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM6;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}