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
    public partial class frm2 : Form
    {
        public FormName ch = FormName.None;

        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = FormName.Login;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
