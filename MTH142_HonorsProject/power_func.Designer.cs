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
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.LightGray;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.value.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(0, 16);
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
            this.power.Location = new System.Drawing.Point(26, 3);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(20, 18);
            this.power.TabIndex = 3;
            this.power.TextChanged += new System.EventHandler(this.Power_TextChanged);
            // 
            // power_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.power);
            this.Controls.Add(this.value);
            this.Name = "power_func";
            this.Size = new System.Drawing.Size(46, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox power;
    }
}
