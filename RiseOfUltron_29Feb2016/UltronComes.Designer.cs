namespace RiseOfUltron_29Feb2016
{
    partial class UltronComes
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
            this.timerSpeech = new System.Windows.Forms.Timer(this.components);
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDialogue
            // 
            this.labelDialogue.AutoSize = true;
            this.labelDialogue.BackColor = System.Drawing.Color.Transparent;
            this.labelDialogue.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDialogue.Location = new System.Drawing.Point(341, 111);
            this.labelDialogue.Name = "labelDialogue";
            this.labelDialogue.Size = new System.Drawing.Size(67, 23);
            this.labelDialogue.TabIndex = 0;
            this.labelDialogue.Text = "Ultron:";
            // 
            // timerSpeech
            // 
            this.timerSpeech.Interval = 50;
            this.timerSpeech.Tick += new System.EventHandler(this.timerSpeech_Tick);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 10;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // UltronComes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.ultronSpeaks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelDialogue);
            this.Name = "UltronComes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltronComes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UltronComes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDialogue;
        private System.Windows.Forms.Timer timerSpeech;
        private System.Windows.Forms.Timer timerFadeOut;
    }
}