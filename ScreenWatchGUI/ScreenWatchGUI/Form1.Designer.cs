namespace ScreenWatchGUI
{
    partial class Form1
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
            this.timeElapsed = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // timeElapsed
            // 
            this.timeElapsed.BackColor = System.Drawing.Color.Black;
            this.timeElapsed.DetectUrls = false;
            this.timeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsed.ForeColor = System.Drawing.Color.Lime;
            this.timeElapsed.Location = new System.Drawing.Point(12, 12);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.ReadOnly = true;
            this.timeElapsed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.timeElapsed.Size = new System.Drawing.Size(183, 96);
            this.timeElapsed.TabIndex = 4;
            this.timeElapsed.Text = "";
            this.timeElapsed.TextChanged += new System.EventHandler(this.timeElapsed_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 120);
            this.Controls.Add(this.timeElapsed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox timeElapsed;
    }
}

