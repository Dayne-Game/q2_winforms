namespace q2_form
{
    partial class SupervisorWindow
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
            this.SupervisorTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SupervisorTitle
            // 
            this.SupervisorTitle.AutoSize = true;
            this.SupervisorTitle.Location = new System.Drawing.Point(2, 9);
            this.SupervisorTitle.Name = "SupervisorTitle";
            this.SupervisorTitle.Size = new System.Drawing.Size(70, 25);
            this.SupervisorTitle.TabIndex = 0;
            this.SupervisorTitle.Text = "label1";
            // 
            // SupervisorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupervisorTitle);
            this.Name = "SupervisorWindow";
            this.Text = "SupervisorWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SupervisorTitle;
    }
}