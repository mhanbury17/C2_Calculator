using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MTH142_HonorsProject
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        //
        // Static Paths
        //

        static string filepath = @"D:\Development\MTH142_HonorsProject\MTH142_HonorsProject\Input_List.txt";
        static List<string> controls = new List<string>();
        // creates a list that can be accessed by any method in this class
        static List<definite_int_control> definite_integrals = new List<definite_int_control>();
        static string direction, frac_index;
        
        #region KeyEvents

        //
        // Event Handler for Arrow Keys
        //

        private void func_ArrowKeyPress(object sender, PreviewKeyDownEventArgs e)
        {
            int num_textboxs = 0;
            foreach (Control c in input_panel.Controls)
            {
                if (c is TextBox)
                {
                    num_textboxs++;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if ((sender as TextBox).SelectionStart == (sender as TextBox).TextLength)
                    {
                        if (!(input_panel.Controls.Count == input_panel.Controls.GetChildIndex((sender as TextBox))))
                        {
                            input_panel.SelectNextControl((sender as TextBox), true, true, true, false);
                        }
                        else
                        {
                            TextBox value = new TextBox();
                            AddTextbox(value);
                        }
                    }
                    break;
                case Keys.Left:
                    if ((sender as TextBox).SelectionStart == 0)
                    {
                        input_panel.SelectNextControl((sender as TextBox), false, true, true, false);
                    }
                    break;
                default:
                    break;
            }
        }


        //
        // Event Handler for KeyPress while Focus is on Textbox
        //

        private void func_KeyPress(object sender, KeyPressEventArgs e)
        {

            bool txt_exist = false;
            int index_num;
            string temp;
            
            switch (Convert.ToInt32(e.KeyChar))
            {
                //on the event that the user presses the divide key a fraction is displayed for the user to enter a numerator and denominator
                case 47:
                    fraction_control[] frac = new fraction_control[1];
                    frac[0] = new fraction_control();
                    input_panel.Controls.Add(frac[0]);
                    frac[0].Margin = new Padding(0, ((input_panel.Height - frac[0].Height) / 2), 5, ((input_panel.Height - frac[0].Height) / 2));
                    input_panel.SelectNextControl(ActiveControl, true, true, true, true);
                    input_panel.Controls.SetChildIndex(frac[0], ActiveControl.TabIndex);
                    frac[0].Leave += new EventHandler(frac_FocusLeave);
                    frac_index = (ActiveControl.TabIndex + 1).ToString();
                    break;
                case 8:
                    index_num = (sender as TextBox).TabIndex;
                    if (((sender as TextBox).Text == null || (sender as TextBox).Text == "") && input_panel.GetNextControl(ActiveControl, false) is fraction_control && (sender as TextBox).SelectionStart == 0 && input_panel.GetNextControl(ActiveControl, false) is power_func)
                    {
                        input_panel.Controls.RemoveAt(index_num - 1);
                        input_panel.SelectNextControl(ActiveControl, false, true, true, true);
                        input_panel.Controls.RemoveAt(index_num - 1);
                    }
                    if ((sender as TextBox).Text == null || (sender as TextBox).Text == "")
                    {

                        if (input_panel.GetNextControl(ActiveControl, false) is definite_int_control || input_panel.GetNextControl(ActiveControl, false) is derivative_control || input_panel.GetNextControl(ActiveControl, false) is indefinite_int_control)
                        {
                            input_panel.Controls.RemoveAt(index_num + 1);
                            input_panel.Controls.RemoveAt(index_num);
                            input_panel.Controls.RemoveAt(index_num - 1);

                            TextBox value = new TextBox();
                            foreach (Control c in input_panel.Controls)
                            {
                                if (c is TextBox)
                                {
                                    txt_exist = true;
                                    c.Focus();
                                }
                            }
                            if (!txt_exist)
                            {
                                AddTextbox(value);
                                value.Margin = new Padding(0, ((input_panel.Height - value.Height) / 2), 0, ((input_panel.Height - value.Height) / 2));
                            }
                        }
                        else if (input_panel.GetNextControl(ActiveControl, false) is fraction_control)
                        {
                            input_panel.Controls.RemoveAt(index_num - 1);
                        }

                    }
                    if (input_panel.GetNextControl(ActiveControl, false) is fraction_control && (sender as TextBox).SelectionStart == 0)
                    {
                        input_panel.Controls.RemoveAt(index_num - 1);
                        if (input_panel.GetNextControl(ActiveControl, false) is TextBox && (sender as TextBox).SelectionStart == 0)
                        {
                            temp = (sender as TextBox).Text;
                            input_panel.SelectNextControl(ActiveControl, false, true, true, true);
                            input_panel.Controls.RemoveAt(index_num-1);
                            ActiveControl.Text = ActiveControl.Text + temp;
                        }
                    }
                    break;
                case 94:
                    power_func[] power= new power_func[1];
                    power[0] = new power_func();
                    input_panel.Controls.Add(power[0]);
                    power[0].Margin = new Padding(3, ((input_panel.Height - power[0].Height) / 2), 3, ((input_panel.Height - power[0].Height) / 2));
                    input_panel.SelectNextControl(ActiveControl, true, true, true, true);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region ButtonClickEvents
        
        //
        // Operand Controls
        //

        //This Method Clears the list containing the problem
        private void Equals_btn_Click(object sender, EventArgs e)
        {

            //clears the text file containing the problem in order to enter a fresh new one
            string[] empty_array = new string[0];
            File.WriteAllLines(filepath, empty_array);
        }

        //event handler that allows the user to add a indefinite integral to the problem
        private void Indef_int_Click(object sender, EventArgs e)
        {

            int index_num;

            //adds control to a list for the final calculation of the problem entered
            string control_type = "indefinite_integral";
            string bound = "unbound";
            string value = "value";
            AddControl(control_type, value, bound);

            //shows the control to the user
            indefinite_int_control[] new_integral = new indefinite_int_control[1];
            new_integral[0] = new indefinite_int_control();
            input_panel.Controls.Add(new_integral[0]);
            controls.Add("indefinite_integral");
            new_integral[0].Margin = new Padding(3, ((input_panel.Height - new_integral[0].Height) / 2), 3, ((input_panel.Height - new_integral[0].Height) / 2));

            TextBox func = new TextBox();
            index_num = AddTextbox(func);

            intergal_dx[] new_dx = new intergal_dx[1];
            new_dx[0] = new intergal_dx();
            input_panel.Controls.Add(new_dx[0]);
            controls.Add("dx");
            new_dx[0].Margin = new Padding(3, ((input_panel.Height - new_dx[0].Height) / 2), 3, ((input_panel.Height - new_dx[0].Height) / 2));

        }

        //event handler that recognizes when the user tries to add a derivative to the problem
        private void Deriv_Click(object sender, EventArgs e)
        {

            int index_num;

            //adds control to a list for the final calculation of the problem entered
            string control_type = "derivative";
            string bound = "unbound";
            string value = "value";
            AddControl(control_type, value, bound);

            //shows the control to the user
            derivative_control[] derivative = new derivative_control[1];
            derivative[0] = new derivative_control();
            input_panel.Controls.Add(derivative[0]);
            controls.Add("dy/dx[");
            derivative[0].Margin = new Padding(3, ((input_panel.Height - derivative[0].Height) / 2), 3, ((input_panel.Height - derivative[0].Height) / 2));

            TextBox func = new TextBox();
            index_num = AddTextbox(func);

            End_Bracket[] end_Brackets = new End_Bracket[1];
            end_Brackets[0] = new End_Bracket();
            input_panel.Controls.Add(end_Brackets[0]);
            controls.Add("]");
            end_Brackets[0].Margin = new Padding(3, ((input_panel.Height - end_Brackets[0].Height) / 2), 3, ((input_panel.Height - end_Brackets[0].Height) / 2));

        }

        //event handler that recognizes when the user tries to add a definite integral to the problem
        private void Def_int_Click(object sender, EventArgs e)
        {
            int index_num;

            //adds control to a list for the final calculation of the problem entered
            string control_type = "definite_integral";
            string bound = "bound";
            string value = "value";
            AddControl(control_type, value, bound);

            //shows the control to the user
            definite_integrals.Add(new definite_int_control());
            input_panel.Controls.Add(definite_integrals[definite_integrals.Count() - 1]);
            definite_integrals[definite_integrals.Count() - 1].Point_A = "a";
            definite_integrals[definite_integrals.Count() - 1].Point_A = "b";
            controls.Add("definite_integral");
            definite_integrals[0].Margin = new Padding(3, ((input_panel.Height - definite_integrals[0].Height) / 2), 3, ((input_panel.Height - definite_integrals[0].Height) / 2));

            TextBox func = new TextBox();
            index_num = AddTextbox(func);

            intergal_dx[] new_dx = new intergal_dx[1];
            new_dx[0] = new intergal_dx();
            input_panel.Controls.Add(new_dx[0]);
            controls.Add("dx");
            new_dx[0].Margin = new Padding(3, ((input_panel.Height - new_dx[0].Height) / 2), 3, ((input_panel.Height - new_dx[0].Height) / 2));

        }

        //
        // Input Display Controls
        //

        //clears the input display section
        private void Clear_input_display_Click(object sender, EventArgs e)
        {
            input_panel.Controls.Clear();

            //clears the text file containing the problem in order to enter a fresh new one
            string[] empty_array = new string[0];
            File.WriteAllLines(filepath, empty_array);
        }

        private void Input_panel_Click(object sender, EventArgs e)
        {
            bool txt_exist = false;

            TextBox value = new TextBox();
            foreach (Control c in input_panel.Controls)
            {
                if (c is TextBox)
                {
                    txt_exist = true;
                }
                if (!(c is TextBox) && Cursor.Position.X >= c.Location.X)
                {
                    txt_exist = false;
                }
            }

            if (!txt_exist)
            {
                AddTextbox(value);
                value.Margin = new Padding(0, ((input_panel.Height - value.Height) / 2), 0, ((input_panel.Height - value.Height) / 2));
            }
        }

        //
        // Application Controls
        //

        //used to exit the application
        private void menu_select_Click(object sender, EventArgs e)
        {
            //clears the text file containing the problem in order to enter a fresh new one
            string[] empty_array = new string[0];
            File.WriteAllLines(filepath, empty_array);

            //closes application
            this.Close();
        }

        #endregion

        #region TextChangedEvents

        //event handler that expands the textbox as the user types in it
        private void func_TextChanged(object sender, EventArgs e)
        {
            string replace_txt = "";
            bool contains_slash = false;

            Size size = TextRenderer.MeasureText((sender as TextBox).Text, (sender as TextBox).Font);
            (sender as TextBox).Width = size.Width;
            (sender as TextBox).Height = size.Height;


            for (int i = 0; i < (sender as TextBox).Text.Length; i++)
            {
                if (!((sender as TextBox).Text.Substring(i , 1) == "/") && !((sender as TextBox).Text.Substring(i, 1) == "^"))
                {
                    replace_txt = replace_txt + (sender as TextBox).Text.Substring(i , 1);
                }
                else
                {
                    contains_slash = true;
                }
            }
            if (contains_slash)
            {
                (sender as TextBox).Text = replace_txt;
            }
        }

        #endregion

        #region input.txt manipulators

        //writes over old input file with updated information
        private void Override_Input(List<string> input)
        {
            StreamWriter writer = new StreamWriter(filepath);

            for (int i = 0; i < input.Count(); i++)
            {
                writer.WriteLine(input[i]);
            }
            writer.Close();
        }

        //reads input file and transfers it to a list
        private List<string> Input_to_List()
        {
            List<string> input = new List<string>();
            string temp;
            int i = 1;
            bool null_status = false;

            StreamReader reader = new StreamReader(filepath);
            while (!null_status)
            {
                temp = reader.ReadLine();
                if (temp != null)
                {
                    input.Add(temp);
                    i++;
                }
                else
                {
                    null_status = true;
                }
            }
            reader.Close();

            return input;
        }

        #endregion

        #region Methods

        //writes to the input text file place holders for information related to the control
        private void AddControl(string control_type, string value, string bound)
        {
            string[] input = new string[5];
            input[0] = control_type;
            input[1] = bound;
            input[2] = "[";
            input[3] = value;
            input[4] = "]";

            File.AppendAllLines(filepath, input);
        }

        private int AddTextbox(TextBox func)
        {
            func.Width = 10;
            func.BorderStyle = BorderStyle.None;
            func.Font = new Font("Ebrima", 12);
            input_panel.Controls.Add(func);
            func.Anchor = AnchorStyles.None;
            func.Focus();
            func.KeyPress += new KeyPressEventHandler(func_KeyPress);
            func.PreviewKeyDown += new PreviewKeyDownEventHandler(func_ArrowKeyPress);
            func.TextChanged += new EventHandler(func_TextChanged);

            return func.TabIndex;
        }

        #endregion

        #region FocusChangeEvents

        private void frac_FocusLeave(object sender, EventArgs e)
        {
            if (!((sender as fraction_control).TabIndex == ActiveControl.TabIndex-1))
            {
                if (direction == "left")
                {
                    foreach (Control c in input_panel.Controls)
                    {
                        if (c.TabIndex+1 == int.Parse(frac_index))
                        {
                            if (!(input_panel.GetNextControl(c, false) is TextBox))
                            {
                                TextBox value = new TextBox();
                                input_panel.Controls.Add(value);
                                input_panel.Controls.SetChildIndex(value, int.Parse(frac_index));
                                input_panel.SelectNextControl(c, false, true, true, true);
                            }
                            else
                            {
                                input_panel.SelectNextControl(c, false, true, true, true);
                            }
                        }
                    }
                }
                else if (direction == "right")
                {
                    foreach (Control c in input_panel.Controls)
                    {
                        if (GetNextControl(c, true) is intergal_dx)
                        {
                            if (c.TabIndex == int.Parse(frac_index))
                            {
                                if (!(input_panel.GetNextControl(c, true) is TextBox))
                                {
                                    TextBox value = new TextBox();
                                    AddTextbox(value);
                                    input_panel.Controls.SetChildIndex(value, int.Parse(frac_index));
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    break;
                                }
                                else if (input_panel.Controls.Count == c.TabIndex + 1)
                                {
                                    TextBox value = new TextBox();
                                    AddTextbox(value);
                                    input_panel.Controls.SetChildIndex(value, int.Parse(frac_index) + 1);
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    break;
                                }
                                else
                                {
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (c.TabIndex == int.Parse(frac_index)-1)
                            {
                                if (!(input_panel.GetNextControl(c, true) is TextBox))
                                {
                                    TextBox value = new TextBox();
                                    AddTextbox(value);
                                    input_panel.Controls.SetChildIndex(value, int.Parse(frac_index));
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    value.Focus();
                                    break;
                                }
                                else if (input_panel.Controls.Count == c.TabIndex + 1)
                                {
                                    TextBox value = new TextBox();
                                    AddTextbox(value);
                                    input_panel.Controls.SetChildIndex(value, int.Parse(frac_index) + 1);
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    break;
                                }
                                else
                                {
                                    input_panel.SelectNextControl(c, true, true, true, true);
                                    break;
                                }
                            }
                        }
                        
                    }
                }
            }
        }

        #endregion

        #region ClassConnections

        //updates input file when bounds are changed on any given definite integral
        public Calculator(string A, string B, string From)
        {
            InitializeComponent();

            int max = definite_integrals.Count();
            int count = 0;
            
            if (From == "def")
            {
                while (!definite_integrals[count].ContainsFocus)
                {
                    count++;
                }

                definite_integrals[count].Point_A = A;
                definite_integrals[count].Point_B = B;

                List<string> input = new List<string>();

                input = Input_to_List();
                input[(count * 3) + 1] = A + "," + B;
                Override_Input(input);
            }
            else if (From == "frac")
            {
                //frac_index = B;
                if (A == "left")
                {
                    direction = "left";
                }
                else if (A == "right")
                {
                    direction = "right";
                }
            }
        }

        #endregion
        
        #region Other

        private void Input_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

    }
}
