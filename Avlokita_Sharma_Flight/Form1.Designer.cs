namespace Avlokita_Sharma_Flight
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.lstCities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSeat = new System.Windows.Forms.ComboBox();
            this.cboMeal = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCities
            // 
            this.lstCities.BackColor = System.Drawing.Color.Red;
            this.lstCities.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 25;
            this.lstCities.Location = new System.Drawing.Point(24, 90);
            this.lstCities.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(214, 204);
            this.lstCities.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(372, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seat Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(676, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meal Preference";
            // 
            // cboSeat
            // 
            this.cboSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cboSeat.FormattingEnabled = true;
            this.cboSeat.Location = new System.Drawing.Point(334, 90);
            this.cboSeat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboSeat.Name = "cboSeat";
            this.cboSeat.Size = new System.Drawing.Size(238, 33);
            this.cboSeat.TabIndex = 4;
            // 
            // cboMeal
            // 
            this.cboMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboMeal.FormattingEnabled = true;
            this.cboMeal.Location = new System.Drawing.Point(634, 90);
            this.cboMeal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboMeal.Name = "cboMeal";
            this.cboMeal.Size = new System.Drawing.Size(238, 33);
            this.cboMeal.TabIndex = 5;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAssign.Location = new System.Drawing.Point(368, 254);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(178, 44);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExit.Location = new System.Drawing.Point(670, 254);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 1085);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cboMeal);
            this.Controls.Add(this.cboSeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCities);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avlokita_Sharma_Flight";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSeat;
        private System.Windows.Forms.ComboBox cboMeal;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnExit;
    }
}

