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
    public partial class frm11 : Form
    {
        public FormName ch = FormName.None;
        public Dictionary<int, RadioButton> groupFourthStep = new Dictionary<int, RadioButton>(6);
        public Dictionary<int, RadioButton> groupFifthStep = new Dictionary<int, RadioButton>(6);
        public Dictionary<int, RadioButton> groupSixthStep = new Dictionary<int, RadioButton>(6);

        public frm11()
        {
            InitializeComponent();

            groupFourthStep.Add(1, radioButton1);
            groupFourthStep.Add(3, radioButton2);
            groupFourthStep.Add(5, radioButton3);
            groupFourthStep.Add(-1, radioButton4);
            groupFifthStep.Add(1, radioButton8);
            groupFifthStep.Add(3, radioButton7);
            groupFifthStep.Add(5, radioButton6);
            groupFifthStep.Add(-1, radioButton5);
            groupSixthStep.Add(1, radioButton12);
            groupSixthStep.Add(3, radioButton11);
            groupSixthStep.Add(5, radioButton10);
            groupSixthStep.Add(-1, radioButton9);
        }

        private void frm11_Load(object sender, EventArgs e)
        {
            textBox1.Text = Goal.FourthStep.correctNum.ToString();
            textBox4.Text = Goal.FifthStep.correctNum.ToString();
            textBox6.Text = Goal.SixthStep.correctNum.ToString();

            try
            {
                groupFourthStep[Goal.FourthStep.distance].Checked = true;
            }
            catch (Exception)
            {
                groupFourthStep[-1].Checked = true;
                textBox2.Text = Goal.FourthStep.distance.ToString();
            }

            try
            {
                groupFifthStep[Goal.FifthStep.distance].Checked = true;
            }
            catch (Exception)
            {
                groupFifthStep[-1].Checked = true;
                textBox3.Text = Goal.FifthStep.distance.ToString();
            }

            try
            {
                groupSixthStep[Goal.SixthStep.distance].Checked = true;
            }
            catch (Exception)
            {
                groupSixthStep[-1].Checked = true;
                textBox5.Text = Goal.SixthStep.distance.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Goal.FourthStep.correctNum = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
            }

            try
            {
                Goal.FifthStep.correctNum = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception exception)
            {
            }

            try
            {
                Goal.SixthStep.correctNum = Convert.ToInt32(textBox6.Text);
            }
            catch (Exception exception)
            {
            }

            foreach (var rb in groupFourthStep)
            {
                if (rb.Value.Checked)
                    if (rb.Key != -1) Goal.FourthStep.distance = rb.Key;
                    else
                    {
                        try
                        {
                            Goal.FourthStep.distance = Convert.ToInt32(textBox2.Text);
                        }
                        catch (Exception)
                        {
                        }
                    }
            }

            foreach (var rb in groupFifthStep)
            {
                if (rb.Value.Checked)
                    if (rb.Key != -1) Goal.FifthStep.distance = rb.Key;
                    else
                    {
                        try
                        {
                            Goal.FifthStep.distance = Convert.ToInt32(textBox3.Text);
                        }
                        catch (Exception)
                        {
                        }
                    }
            }

            foreach (var rb in groupSixthStep)
            {
                if (rb.Value.Checked)
                    if (rb.Key != -1) Goal.SixthStep.distance = rb.Key;
                    else
                    {
                        try
                        {
                            Goal.SixthStep.distance = Convert.ToInt32(textBox5.Text);
                        }
                        catch (Exception)
                        {
                        }
                    }
            }

            ch = FormName.FRM7;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}