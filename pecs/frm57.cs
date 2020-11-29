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
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm57 : Form
    {
        public FormName ch = FormName.None;
        public frm57()
        {
            InitializeComponent();
        }
        private void frm57_Load(object sender, EventArgs e)
        {
            label2.Text = Topic43State.totalQuestion;
        }

        private void frm_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM56;
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
