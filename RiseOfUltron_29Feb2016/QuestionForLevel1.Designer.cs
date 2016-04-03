namespace RiseOfUltron_29Feb2016
{
    partial class QuestionForLevel1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(76, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 363);
            this.panel1.TabIndex = 0;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(5, 5);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(111, 20);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "labelQuestion";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(131)))), ((int)(((byte)(134)))));
            this.textBoxAnswer.Location = new System.Drawing.Point(329, 449);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(164, 22);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.Location = new System.Drawing.Point(313, 508);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(198, 42);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(73, 432);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(84, 17);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "labelAnswer";
            this.labelAnswer.Visible = false;
            // 
            // QuestionForLevel1
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.ULTRON;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 592);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionForLevel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelQuestion;
        public System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonSubmit;
        public System.Windows.Forms.Label labelAnswer;
    }
}