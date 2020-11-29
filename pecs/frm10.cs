using System;
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
    public partial class frm10 : Form
    {
        public int Options = 0;
        public FormName ch = FormName.None;
        private List<String> tempResList = new List<string>();
        private Dictionary<PictureBox, String> cor = new Dictionary<PictureBox, string>();

        public frm10()
        {
            InitializeComponent();
        }

        private void frm10_Load(object sender, EventArgs e)
        {
            cor[p11] = "要";
            cor[p21] = "看見";
            cor[p31] = "有";
            cor[p41] = "這是";
            cor[p51] = "那是";
            Topic.Topic78State.regList.ForEach(v => tempResList.Add(v));
            UpdateSelection();
        }

        private bool IsSelected(String s)
        {
            var res = tempResList.Find(v => v == s);
            if (res == null)
            {
                return false;
            }

            Console.WriteLine(res, s);
            return res == s;
        }

        private void UpdateSelection()
        {
            p11.Image = IsSelected(cor[p11])
                ? Properties.Resources.option_click
                : Properties.Resources.option_free;
            p21.Image = IsSelected(cor[p21])
                ? Properties.Resources.option_click
                : Properties.Resources.option_free;
            p31.Image = IsSelected(cor[p31])
                ? Properties.Resources.option_click
                : Properties.Resources.option_free;
            p41.Image = IsSelected(cor[p41])
                ? Properties.Resources.option_click
                : Properties.Resources.option_free;
            p51.Image = IsSelected(cor[p51])
                ? Properties.Resources.option_click
                : Properties.Resources.option_free;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ch = FormName.FRM8;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Topic.Topic78State.regList.Clear();
            tempResList.ForEach(v => Topic.Topic78State.regList.Add(v));
            ch = FormName.FRM8;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            var pic = (PictureBox) sender;
            var res = tempResList.Find(v => v == cor[pic]);
            if (res == null)
            {
                tempResList.Add(cor[pic]);
            }
            else
            {
                tempResList.Remove(cor[pic]);
            }

            UpdateSelection();
        }
    }
}