namespace MTH142_HonorsProject
{
    partial class fraction_control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.div_bar = new System.Windows.Forms.Panel();
            this.numerator = new System.Windows.Forms.TextBox();
            this.denominator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // div_bar
            // 
            this.div_bar.BackColor = System.Drawing.Color.Black;
            this.div_bar.Location = new System.Drawing.Point(0, 62);
            this.div_bar.Name = "div_bar";
            this.div_bar.Size = new System.Drawing.Size(20, 2);
            this.div_bar.TabIndex = 0;
            // 
            // numerator
            // 
            this.numerator.BackColor = System.Drawing.Color.LightGray;
            this.numerator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numerator.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerator.Location = new System.Drawing.Point(0, 35);
            this.numerator.Name = "numerator";
            this.numerator.Size = new System.Drawing.Size(20, 18);
            this.numerator.TabIndex = 1;
            this.numerator.TextChanged += new System.EventHandler(this.Numerator_TextChanged);
            this.numerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerator_KeyPress);
            // 
            // denominator
            // 
            this.denominator.BackColor = System.Drawing.Color.LightGray;
            this.denominator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.denominator.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominator.Location = new System.Drawing.Point(0, 70);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(20, 18);
            this.denominator.TabIndex = 2;
            this.denominator.TextChanged += new System.EventHandler(this.Denominator_TextChanged);
            this.denominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Denominator_KeyPress);
            // 
            // fraction_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.denominator);
            this.Controls.Add(this.numerator);
            this.Controls.Add(this.div_bar);
            this.Name = "fraction_control";
            this.Size = new System.Drawing.Size(20, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel div_bar;
        private System.Windows.Forms.TextBox numerator;
        private System.Windows.Forms.TextBox denominator;
    }
}
