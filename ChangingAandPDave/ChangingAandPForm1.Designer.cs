namespace ChangingAandPDave
{
    partial class frmChangingAandP
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblPerimeterAns = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(2, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(136, 32);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(2, 57);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(126, 32);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m):";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(29, 135);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(35, 13);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "label1";
            // 
            // lblPerimeterAns
            // 
            this.lblPerimeterAns.AutoSize = true;
            this.lblPerimeterAns.Location = new System.Drawing.Point(113, 135);
            this.lblPerimeterAns.Name = "lblPerimeterAns";
            this.lblPerimeterAns.Size = new System.Drawing.Size(35, 13);
            this.lblPerimeterAns.TabIndex = 3;
            this.lblPerimeterAns.Text = "label2";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(29, 195);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "label3";
            // 
            // lblAreaAns
            // 
            this.lblAreaAns.AutoSize = true;
            this.lblAreaAns.Location = new System.Drawing.Point(113, 195);
            this.lblAreaAns.Name = "lblAreaAns";
            this.lblAreaAns.Size = new System.Drawing.Size(35, 13);
            this.lblAreaAns.TabIndex = 5;
            this.lblAreaAns.Text = "label4";
            // 
            // frmChangingAandP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAreaAns);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeterAns);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmChangingAandP";
            this.Text = "Changing Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblPerimeterAns;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaAns;
    }
}

