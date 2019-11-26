using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTH142_HonorsProject
{
    public partial class fraction_control : UserControl
    {
        public fraction_control()
        {
            InitializeComponent();
            numerator.PreviewKeyDown += new PreviewKeyDownEventHandler(Numerator_PreviewKeyDown);
            denominator.PreviewKeyDown += new PreviewKeyDownEventHandler(Denominator_PreviewKeyDown);
        }

        private void Numerator_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText((sender as TextBox).Text, (sender as TextBox).Font);
            (sender as TextBox).Width = size.Width;
            (sender as TextBox).Height = size.Height;

            if ((sender as TextBox).Text == null || (sender as TextBox).Text == "")
            {
                (sender as TextBox).BackColor = Color.LightGray;
            }
            else
            {
                (sender as TextBox).BackColor = Color.White;
            }

            if (numerator.Width >= denominator.Width)
            {
                div_bar.Width = numerator.Width;
                this.Width = numerator.Width;
                denominator.Width = numerator.Width;
            }
            else if (denominator.Width >= numerator.Width)
            {
                div_bar.Width = denominator.Width;
                this.Width = denominator.Width;
                numerator.Width = denominator.Width;
            }
            else
            {
                div_bar.Width = 20;
            }
            (sender as TextBox).TextAlign = HorizontalAlignment.Center;
        }

        private void Numerator_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string direction, index, From = "frac";
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if ((sender as TextBox).SelectionStart == (sender as TextBox).TextLength)
                    {
                        denominator.Focus();
                    }
                    break;
                case Keys.Left:
                    if ((sender as TextBox).SelectionStart == 0)
                    {
                        direction = "left";
                        index = ActiveControl.TabIndex.ToString();

                        Calculator sendTo = new Calculator(direction, index, From);
                        this.Parent.Focus();
                    }
                    break;
                case Keys.Down:
                    denominator.Focus();
                    break;
                default:
                    break;
            }
        }

        private void Denominator_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText((sender as TextBox).Text, (sender as TextBox).Font);
            (sender as TextBox).Width = size.Width;
            (sender as TextBox).Height = size.Height;

            if ((sender as TextBox).Text == null || (sender as TextBox).Text == "")
            {
                (sender as TextBox).BackColor = Color.LightGray;
            }
            else
            {
                (sender as TextBox).BackColor = Color.White;
            }

            if (numerator.Width >= denominator.Width)
            {
                div_bar.Width = numerator.Width;
                this.Width = numerator.Width;
                denominator.Width = numerator.Width;
            }
            else if (denominator.Width >= numerator.Width)
            {
                div_bar.Width = denominator.Width;
                this.Width = denominator.Width;
                numerator.Width = denominator.Width;
            }
            else
            {
                div_bar.Width = 20;
            }
            (sender as TextBox).TextAlign = HorizontalAlignment.Center;
        }

        private void Denominator_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string direction, index, From = "frac";
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if ((sender as TextBox).SelectionStart == (sender as TextBox).TextLength)
                    {
                        if ((sender as TextBox).SelectionStart == (sender as TextBox).TextLength)
                        {
                            direction = "right";
                            index = ActiveControl.TabIndex.ToString();

                            Calculator sendTo = new Calculator(direction, index, From);
                            this.Parent.Focus();
                        }
                    }
                    break;
                case Keys.Left:
                    if ((sender as TextBox).SelectionStart == 0)
                    {
                        numerator.Focus();
                    }
                    break;
                case Keys.Up:
                    numerator.Focus();
                    break;
                default:
                    break;
            }
        }

        private void Numerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            string confirmation, index, From = "frac";
            switch (Convert.ToInt32(e.KeyChar))
            {
                case 8:
                    if (numerator.Text == null || numerator.Text == "")
                    {
                        confirmation = "remove";
                        index = this.TabIndex.ToString();
                        
                        Calculator sendTo = new Calculator(confirmation, index, From);
                    }
                    break;
                default:
                    break;
            }
        }

        private void Denominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            string confirmation, index, From = "frac";
            switch (Convert.ToInt32(e.KeyChar))
            {
                case 8:
                    if (denominator.Text == null || denominator.Text == "")
                    {
                        confirmation = "remove";
                        index = this.TabIndex.ToString();

                        Calculator sendTo = new Calculator(confirmation, index, From);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
