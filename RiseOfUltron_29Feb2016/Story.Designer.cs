namespace RiseOfUltron_29Feb2016
{
    partial class Story
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
            this.labelDialogue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.timerSpeech = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDialogue
            // 
            this.labelDialogue.AutoSize = true;
            this.labelDialogue.BackColor = System.Drawing.Color.Transparent;
            this.labelDialogue.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDialogue.Location = new System.Drawing.Point(141, 118);
            this.labelDialogue.Name = "labelDialogue";
            this.labelDialogue.Size = new System.Drawing.Size(18, 25);
            this.labelDialogue.TabIndex = 0;
            this.labelDialogue.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerFade
            // 
            this.timerFade.Interval = 10;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // timerSpeech
            // 
            this.timerSpeech.Interval = 20;
            this.timerSpeech.Tick += new System.EventHandler(this.timerSpeech_Tick);
            // 
            // Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.nik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelDialogue);
            this.Name = "Story";
            this.Text = "Story";
            this.Shown += new System.EventHandler(this.Story_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDialogue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.Timer timerSpeech;
    }
}