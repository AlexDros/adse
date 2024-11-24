namespace McDoKiosk
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
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnDineIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.BackColor = System.Drawing.Color.White;
            this.btnTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOut.Location = new System.Drawing.Point(249, 252);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(143, 115);
            this.btnTakeOut.TabIndex = 1;
            this.btnTakeOut.Text = "Take-Out";
            this.btnTakeOut.UseVisualStyleBackColor = false;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // btnDineIn
            // 
            this.btnDineIn.BackColor = System.Drawing.Color.White;
            this.btnDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDineIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDineIn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDineIn.Location = new System.Drawing.Point(100, 252);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(143, 115);
            this.btnDineIn.TabIndex = 0;
            this.btnDineIn.Text = "Dine-In";
            this.btnDineIn.UseVisualStyleBackColor = false;
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(492, 618);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnDineIn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDineIn;
        private System.Windows.Forms.Button btnTakeOut;
    }
}

