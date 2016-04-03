namespace RiseOfUltron_29Feb2016
{
    partial class Description
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TypewriteText_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TypewriteText_Click
            // 
            this.TypewriteText_Click.BackColor = System.Drawing.Color.Transparent;
            this.TypewriteText_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypewriteText_Click.FlatAppearance.BorderSize = 0;
            this.TypewriteText_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TypewriteText_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TypewriteText_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypewriteText_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypewriteText_Click.ForeColor = System.Drawing.Color.White;
            this.TypewriteText_Click.Location = new System.Drawing.Point(432, 573);
            this.TypewriteText_Click.Name = "TypewriteText_Click";
            this.TypewriteText_Click.Size = new System.Drawing.Size(182, 74);
            this.TypewriteText_Click.TabIndex = 2;
            this.TypewriteText_Click.Text = "Next";
            this.TypewriteText_Click.UseVisualStyleBackColor = false;
            this.TypewriteText_Click.Click += new System.EventHandler(this.button_TypewriteText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(233, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.rules;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypewriteText_Click);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Description";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Description";
            this.Load += new System.EventHandler(this.Description_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TypewriteText_Click;
        private System.Windows.Forms.Label label2;
    }
}