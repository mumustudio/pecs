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
using static pecs.state.Topic;

namespace pecs
{
    public partial class frm23 : Form
    {
        public FormName ch = FormName.None;
        public frm23()
        {
            InitializeComponent();
        }

        private void frm23_Load(object sender, EventArgs e)
        {
            label6.Text = Topic22State.T;
            label1.Text = "我" + Topic22State.T;
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

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Topic22State.chosenImage = btn.BackgroundImage;
            ch = FormName.FRM24;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
