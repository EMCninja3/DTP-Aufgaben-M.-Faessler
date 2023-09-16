namespace Randomizer
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdGoToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdGoToHome
            // 
            this.CmdGoToHome.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdGoToHome.Location = new System.Drawing.Point(0, 0);
            this.CmdGoToHome.Name = "CmdGoToHome";
            this.CmdGoToHome.Size = new System.Drawing.Size(990, 662);
            this.CmdGoToHome.TabIndex = 0;
            this.CmdGoToHome.Text = "Randomizer";
            this.CmdGoToHome.UseVisualStyleBackColor = true;
            this.CmdGoToHome.Click += new System.EventHandler(this.CmdGoToHome_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.CmdGoToHome);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "SplashScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdGoToHome;
    }
}