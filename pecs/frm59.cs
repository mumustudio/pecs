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
using static pecs.state.Goal;
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm59 : Form
    {
        public FormName ch = FormName.None;
        public frm59()
        {
            InitializeComponent();
        }

        private void frm59_Load(object sender, EventArgs e)
        {
            if (Topic43State.T2 != "")
            {
                label2.Text = Topic43State.totalQuestion;
                label3.Text = Topic43State.T2;
            }
            pictureBox1.Image = Topic58State.chosenImage;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM58;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            CurrentState.correctNum++;
            if (CurrentState.correctNum >= FifthStep.correctNum)
            {
                ch = FormName.FRM62;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ch = FormName.FRM60;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_wrong_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM61;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
