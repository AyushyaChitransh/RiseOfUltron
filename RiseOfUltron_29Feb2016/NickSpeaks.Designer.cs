namespace RiseOfUltron_29Feb2016
{
    partial class NickSpeaks
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
            this.timerSpeech = new System.Windows.Forms.Timer(this.components);
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.labelDialogue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerSpeech
            // 
            this.timerSpeech.Interval = 50;
            this.timerSpeech.Tick += new System.EventHandler(this.timerSpeech_Tick);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 5;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // labelDialogue
            // 
            this.labelDialogue.AutoSize = true;
            this.labelDialogue.BackColor = System.Drawing.Color.Transparent;
            this.labelDialogue.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDialogue.Location = new System.Drawing.Point(102, 112);
            this.labelDialogue.Name = "labelDialogue";
            this.labelDialogue.Size = new System.Drawing.Size(51, 23);
            this.labelDialogue.TabIndex = 1;
            this.labelDialogue.Text = "Fury:";
            // 
            // NickSpeaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiseOfUltron_29Feb2016.Properties.Resources.nik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelDialogue);
            this.Name = "NickSpeaks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NickSpeaks_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSpeech;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Label labelDialogue;
    }
}