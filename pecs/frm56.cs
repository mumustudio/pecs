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

namespace pecs
{
    public partial class frm56 : Form
    {
        public FormName ch = FormName.None;
        private int countDown = 10;
        public frm56()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frm56_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                countDown = 10;
                timer1.Stop();

                ch = FormName.FRM58;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            label9.Text = countDown.ToString();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM58;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM57;
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
