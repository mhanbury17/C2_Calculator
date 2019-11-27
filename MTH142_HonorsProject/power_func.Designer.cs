namespace MTH142_HonorsProject
{
    partial class power_func
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
            this.value = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.TextBox();
            this.left_par = new System.Windows.Forms.Label();
            this.right_par = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.LightGray;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.value.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(10, 16);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(20, 18);
            this.value.TabIndex = 2;
            this.value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.LightGray;
            this.power.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.power.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(46, 3);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(20, 18);
            this.power.TabIndex = 3;
            this.power.TextChanged += new System.EventHandler(this.Power_TextChanged);
            // 
            // left_par
            // 
            this.left_par.AutoSize = true;
            this.left_par.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_par.Font = new System.Drawing.Font("Ebrima", 7.8F);
            this.left_par.Location = new System.Drawing.Point(-3, 16);
            this.left_par.Name = "left_par";
            this.left_par.Size = new System.Drawing.Size(13, 19);
            this.left_par.TabIndex = 4;
            this.left_par.Text = "(";
            // 
            // right_par
            // 
            this.right_par.AutoSize = true;
            this.right_par.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_par.Font = new System.Drawing.Font("Ebrima", 7.8F);
            this.right_par.Location = new System.Drawing.Point(32, 16);
            this.right_par.Name = "right_par";
            this.right_par.Size = new System.Drawing.Size(13, 19);
            this.right_par.TabIndex = 5;
            this.right_par.Text = ")";
            // 
            // power_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.right_par);
            this.Controls.Add(this.left_par);
            this.Controls.Add(this.power);
            this.Controls.Add(this.value);
            this.Name = "power_func";
            this.Size = new System.Drawing.Size(67, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.Label left_par;
        private System.Windows.Forms.Label right_par;
    }
}
