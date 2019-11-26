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
    public partial class power_func : UserControl
    {
        public power_func()
        {
            InitializeComponent();
        }

        private string _value;
        private string _power;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Power
        {
            get { return _power; }
            set { _power = value; }
        }

        private void Power_TextChanged(object sender, EventArgs e)
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

            this.Width = power.Width + value.Width + 3;
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText((sender as TextBox).Text, (sender as TextBox).Font);
            (sender as TextBox).Width = size.Width;
            (sender as TextBox).Height = size.Height;

            power.Location = new Point(value.Width+3, power.Location.Y);

            if ((sender as TextBox).Text == null || (sender as TextBox).Text == "")
            {
                (sender as TextBox).BackColor = Color.LightGray;
            }
            else
            {
                (sender as TextBox).BackColor = Color.White;
            }

            this.Width = power.Width + value.Width + 3;
        }
    }
}
