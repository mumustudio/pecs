﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pecs.state;

namespace pecs
{
    public partial class frm88 : Form
    {
        public FormName ch = FormName.None;
        public frm88()
        {
            InitializeComponent();
        }

        private void frm88_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Topic.Topic78State.chosenImage;
            label8.Text = Topic.Topic78State.T2;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM87;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
