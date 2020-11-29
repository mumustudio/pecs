using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pecs.state;

namespace pecs
{
    public partial class frm9 : Form
    {
        public FormName ch = FormName.None;
        public int p1Index = 0;
        public int p2Index = 1;
        public int p3Index = 2;

        public frm9()
        {
            InitializeComponent();
        }

        private void frm9_Load(object sender, EventArgs e)
        {
            ImageInst.imageList.ForEach(v => v.tempSelect = v.selected);
            loadImage();
        }

        private void loadImage()
        {
            if (p1Index < ImageInst.imageList.Count)
            {
                p12.Image = ImageInst.imageList[p1Index].image;
                p13.Text = ImageInst.imageList[p1Index].title;
                p11.Image = ImageInst.imageList[p1Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
            else
            {
                p12.Image = null;
                p13.Text = "";
            }

            if (p2Index < ImageInst.imageList.Count)
            {
                p22.Image = ImageInst.imageList[p2Index].image;
                p23.Text = ImageInst.imageList[p2Index].title;
                p21.Image = ImageInst.imageList[p2Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
            else
            {
                p22.Image = null;
                p23.Text = "";
            }

            if (p3Index < ImageInst.imageList.Count)
            {
                p32.Image = ImageInst.imageList[p3Index].image;
                p33.Text = ImageInst.imageList[p3Index].title;
                p31.Image = ImageInst.imageList[p3Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
            else
            {
                p32.Image = null;
                p33.Text = "";
            }

            label1.Text = $"{p1Index / 3 + 1}/{ImageInst.imageList.Count / 3 + 1}";
        }

        private void p11_Click(object sender, EventArgs e)
        {
            if (p1Index < ImageInst.imageList.Count)
            {
                ImageInst.imageList[p1Index].tempSelect = !ImageInst.imageList[p1Index].tempSelect;
                p11.Image = ImageInst.imageList[p1Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
        }

        private void p21_Click(object sender, EventArgs e)
        {
            if (p2Index < ImageInst.imageList.Count)
            {
                ImageInst.imageList[p2Index].tempSelect = !ImageInst.imageList[p2Index].tempSelect;
                p21.Image = ImageInst.imageList[p2Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
        }

        private void p31_Click(object sender, EventArgs e)
        {
            if (p3Index < ImageInst.imageList.Count)
            {
                ImageInst.imageList[p3Index].tempSelect = !ImageInst.imageList[p3Index].tempSelect;
                p31.Image = ImageInst.imageList[p3Index].tempSelect
                    ? Properties.Resources.option_click
                    : Properties.Resources.option_free;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (p1Index - 3 >= 0)
            {
                p1Index -= 3;
                p2Index -= 3;
                p3Index -= 3;
            }
            else
            {
                p1Index = 0;
                p2Index = 1;
                p3Index = 2;
            }

            loadImage();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (p1Index + 3 < ImageInst.imageList.Count)
            {
                p1Index += 3;
                p2Index += 3;
                p3Index += 3;
            }

            loadImage();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (ImageInst.imageList.FindAll(v => v.tempSelect).Count != 5)
            {
                MessageBox.Show("只能挑選5個", "錯誤", MessageBoxButtons.OK);
            }
            else
            {
                ImageInst.imageList.ForEach(v =>
                    {
                        v.selected = v.tempSelect;
                        v.tempSelect = false;
                    }
                );
                ch = FormName.FRM8;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ImageInst.imageList.ForEach(v =>
                {
                    v.tempSelect = false;
                }
            );
            ch = FormName.FRM8;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}