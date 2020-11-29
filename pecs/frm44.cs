using pecs.state;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm44 : Form
    {
        private int countDown = 10;
        public FormName ch = FormName.None;
        public frm44()
        {
            InitializeComponent();
        }
    

        private void frm44_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                countDown = 10;
                timer1.Stop();

                ch = FormName.FRM46;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            label9.Text = countDown.ToString();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM46;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM45;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM43;
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
