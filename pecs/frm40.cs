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
    public partial class frm40 : Form
    {
        public FormName ch = FormName.None;
        public frm40()
        {
            InitializeComponent();
        }

        private void frm40_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Topic.advancedPickedImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM39;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
