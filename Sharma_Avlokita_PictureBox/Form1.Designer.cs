namespace Sharma_Avlokita_PictureBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.picAutoSize = new System.Windows.Forms.PictureBox();
            this.picStretch = new System.Windows.Forms.PictureBox();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(475, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Center Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(475, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zoom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(66, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stretch Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(882, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Auto Size";
            // 
            // picNormal
            // 
            this.picNormal.Location = new System.Drawing.Point(42, 110);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(334, 313);
            this.picNormal.TabIndex = 5;
            this.picNormal.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.Location = new System.Drawing.Point(480, 110);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(318, 313);
            this.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCenter.TabIndex = 6;
            this.picCenter.TabStop = false;
            // 
            // picAutoSize
            // 
            this.picAutoSize.Location = new System.Drawing.Point(864, 110);
            this.picAutoSize.Name = "picAutoSize";
            this.picAutoSize.Size = new System.Drawing.Size(330, 313);
            this.picAutoSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAutoSize.TabIndex = 7;
            this.picAutoSize.TabStop = false;
            // 
            // picStretch
            // 
            this.picStretch.Location = new System.Drawing.Point(71, 533);
            this.picStretch.Name = "picStretch";
            this.picStretch.Size = new System.Drawing.Size(305, 328);
            this.picStretch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStretch.TabIndex = 8;
            this.picStretch.TabStop = false;
            // 
            // picZoom
            // 
            this.picZoom.Location = new System.Drawing.Point(480, 533);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(318, 328);
            this.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZoom.TabIndex = 9;
            this.picZoom.TabStop = false;
            this.picZoom.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(887, 708);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(307, 31);
            this.txtSize.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Size";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(965, 786);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(229, 74);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1230, 928);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.picStretch);
            this.Controls.Add(this.picAutoSize);
            this.Controls.Add(this.picCenter);
            this.Controls.Add(this.picNormal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avlokita_Sharma_PictureBox";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.PictureBox picAutoSize;
        private System.Windows.Forms.PictureBox picStretch;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

