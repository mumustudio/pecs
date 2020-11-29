﻿using pecs.state;
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
    public partial class frm28 : Form
    {
        public FormName ch = FormName.None;
        public frm28()
        {
            InitializeComponent();
        }

        private void frm28_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Topic.advancedPickedImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void redirectTo()
        {
            ch = FormName.FRM29;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            redirectTo();
        }
    }
}
