namespace RiseOfUltron_29Feb2016
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.textBoxTeamId = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // textBoxTeamId
            // 
            this.textBoxTeamId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTeamId.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxTeamId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamId.ForeColor = System.Drawing.Color.White;
            this.textBoxTeamId.Location = new System.Drawing.Point(154, 367);
            this.textBoxTeamId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeamId.Name = "textBoxTeamId";
            this.textBoxTeamId.Size = new System.Drawing.Size(152, 28);
            this.textBoxTeamId.TabIndex = 3;
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName1.ForeColor = System.Drawing.Color.White;
            this.textBoxName1.Location = new System.Drawing.Point(154, 201);
            this.textBoxName1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(563, 28);
            this.textBoxName1.TabIndex = 1;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName2.ForeColor = System.Drawing.Color.White;
            this.textBoxName2.Location = new System.Drawing.Point(154, 287);
            this.textBoxName2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(563, 28);
            this.textBoxName2.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Location = new System.Drawing.Point(743, 206);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(155, 109);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 444);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxTeamId);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxName1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxTeamId;
        public System.Windows.Forms.TextBox textBoxName1;
        public System.Windows.Forms.TextBox textBoxName2;
        public System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

