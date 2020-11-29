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
    public partial class frm68 : Form
    {
        public FormName ch = FormName.None;
        public frm68()
        {
            InitializeComponent();
        }

        private void frm68_Load(object sender, EventArgs e)
        {
            var selectedImgList = ImageInst.imageList.FindAll(v => v.selected);
            p1.BackgroundImage = selectedImgList[0].image;
            p2.BackgroundImage = selectedImgList[1].image;
            p3.BackgroundImage = selectedImgList[2].image;
            p4.BackgroundImage = selectedImgList[3].image;
            p5.BackgroundImage = selectedImgList[4].image;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = Topic.topicForm;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void redirectTo()
        {
            ch = FormName.FRM69;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            Topic.Topic68State.chosenImage = (Image)((Button)sender).BackgroundImage.Clone();
            redirectTo();
        }
    }
}
