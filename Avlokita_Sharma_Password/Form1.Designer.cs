namespace Avlokita_Sharma_Password
{
    partial class Avlokita_Sharma_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_pass = new System.Windows.Forms.Button();
            this.Exit_pass = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter your Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submit_pass
            // 
            this.Submit_pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit_pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Submit_pass.Location = new System.Drawing.Point(75, 225);
            this.Submit_pass.Name = "Submit_pass";
            this.Submit_pass.Size = new System.Drawing.Size(153, 85);
            this.Submit_pass.TabIndex = 1;
            this.Submit_pass.Text = "Submit";
            this.Submit_pass.UseVisualStyleBackColor = false;
            this.Submit_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_pass
            // 
            this.Exit_pass.BackColor = System.Drawing.Color.Brown;
            this.Exit_pass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_pass.Location = new System.Drawing.Point(394, 225);
            this.Exit_pass.Name = "Exit_pass";
            this.Exit_pass.Size = new System.Drawing.Size(168, 85);
            this.Exit_pass.TabIndex = 2;
            this.Exit_pass.Text = "Exit";
            this.Exit_pass.UseVisualStyleBackColor = false;
            this.Exit_pass.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(389, 31);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Tag = "MyPassword00";
            // 
            // Avlokita_Sharma_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 373);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Exit_pass);
            this.Controls.Add(this.Submit_pass);
            this.Controls.Add(this.label1);
            this.Name = "Avlokita_Sharma_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avlokita_Sharma_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit_pass;
        private System.Windows.Forms.Button Exit_pass;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

