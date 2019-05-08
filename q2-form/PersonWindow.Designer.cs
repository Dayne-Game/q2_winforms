namespace q2_form
{
    partial class PersonWindow
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
            this.PersonTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonTitle
            // 
            this.PersonTitle.AutoSize = true;
            this.PersonTitle.Location = new System.Drawing.Point(12, 9);
            this.PersonTitle.Name = "PersonTitle";
            this.PersonTitle.Size = new System.Drawing.Size(70, 25);
            this.PersonTitle.TabIndex = 0;
            this.PersonTitle.Text = "label1";
            // 
            // PersonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonTitle);
            this.Name = "PersonWindow";
            this.Text = "PersonWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonTitle;
    }
}