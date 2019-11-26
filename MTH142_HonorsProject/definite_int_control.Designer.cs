namespace MTH142_HonorsProject
{
    partial class definite_int_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(definite_int_control));
            this.bound_a = new System.Windows.Forms.TextBox();
            this.bound_b = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bound_a
            // 
            this.bound_a.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bound_a.Font = new System.Drawing.Font("Ebrima", 8F);
            this.bound_a.ForeColor = System.Drawing.Color.White;
            this.bound_a.Location = new System.Drawing.Point(0, 49);
            this.bound_a.Margin = new System.Windows.Forms.Padding(2);
            this.bound_a.Name = "bound_a";
            this.bound_a.Size = new System.Drawing.Size(18, 22);
            this.bound_a.TabIndex = 0;
            this.bound_a.TextChanged += new System.EventHandler(this.Bound_a_TextChanged);
            // 
            // bound_b
            // 
            this.bound_b.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bound_b.Font = new System.Drawing.Font("Ebrima", 8F);
            this.bound_b.ForeColor = System.Drawing.Color.White;
            this.bound_b.Location = new System.Drawing.Point(37, 34);
            this.bound_b.Margin = new System.Windows.Forms.Padding(2);
            this.bound_b.Name = "bound_b";
            this.bound_b.Size = new System.Drawing.Size(18, 22);
            this.bound_b.TabIndex = 1;
            this.bound_b.TextChanged += new System.EventHandler(this.Bound_b_TextChanged);
            // 
            // definite_int_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bound_b);
            this.Controls.Add(this.bound_a);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "definite_int_control";
            this.Size = new System.Drawing.Size(56, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bound_a;
        private System.Windows.Forms.TextBox bound_b;
    }
}
