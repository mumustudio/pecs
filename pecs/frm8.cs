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
    public partial class frm8 : Form
    {
        public FormName ch = FormName.None;
        public frm8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM7;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM9;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM10;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
