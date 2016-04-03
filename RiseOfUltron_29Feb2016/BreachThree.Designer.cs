namespace RiseOfUltron_29Feb2016
{
    partial class BreachThree
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(393, 553);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(249, 82);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseHover += new System.EventHandler(this.timer3_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(0, 662);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1045, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // BreachThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.begin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreachThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreachThree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BreachThree_FormClosing);
            this.Load += new System.EventHandler(this.BreachThree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}