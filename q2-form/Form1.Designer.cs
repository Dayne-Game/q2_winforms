namespace q2_form
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
            this.Title = new System.Windows.Forms.Label();
            this.PersonBtn = new System.Windows.Forms.Button();
            this.SupervisorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Title.Location = new System.Drawing.Point(135, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(531, 63);
            this.Title.TabIndex = 0;
            this.Title.Text = "Question 2 Winforms";
            // 
            // PersonBtn
            // 
            this.PersonBtn.Location = new System.Drawing.Point(128, 224);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(191, 116);
            this.PersonBtn.TabIndex = 1;
            this.PersonBtn.Text = "Person";
            this.PersonBtn.UseVisualStyleBackColor = true;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // SupervisorBtn
            // 
            this.SupervisorBtn.Location = new System.Drawing.Point(475, 224);
            this.SupervisorBtn.Name = "SupervisorBtn";
            this.SupervisorBtn.Size = new System.Drawing.Size(191, 116);
            this.SupervisorBtn.TabIndex = 2;
            this.SupervisorBtn.Text = "Supervisor";
            this.SupervisorBtn.UseVisualStyleBackColor = true;
            this.SupervisorBtn.Click += new System.EventHandler(this.SupervisorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupervisorBtn);
            this.Controls.Add(this.PersonBtn);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button PersonBtn;
        private System.Windows.Forms.Button SupervisorBtn;
    }
}

