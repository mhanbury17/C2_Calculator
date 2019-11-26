using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MTH142_HonorsProject
{
    public partial class definite_int_control : UserControl
    {
        public definite_int_control()
        {
            InitializeComponent();
        }

        //this region contains the property references for the textboxes that bound the integral
        #region Props

        private string _a;
        private string _b;
        private string _from;

        [Category("Bounds")]
        public string Point_A
        {
            get { return _a; }
            set { _a = value; }
        }

        [Category("Bounds")]
        public string Point_B
        {
            get { return _b; }
            set { _b = value; }
        }

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        #endregion

        //this event handler sends a message back to the main class containing the lower bound for the integral when it is changed in the textbox
        private void Bound_a_TextChanged(object sender, EventArgs e)
        {
            Point_A = bound_a.Text;
            From = "def";
            Calculator sendTo = new Calculator(Point_A, Point_B, From);
        }

        //this event handler sends a message back to the main class containing the upper bound for the integral when it is changed in the textbox
        private void Bound_b_TextChanged(object sender, EventArgs e)
        {
            Point_B = bound_b.Text;
            From = "def";
            Calculator sendTo = new Calculator(Point_A, Point_B, From);
        }
    }
}
