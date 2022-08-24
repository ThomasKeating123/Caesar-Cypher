namespace Caesar_Cipher
{
    partial class Form
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
            this.TXTinput = new System.Windows.Forms.TextBox();
            this.TXToutput = new System.Windows.Forms.TextBox();
            this.LBLinput = new System.Windows.Forms.Label();
            this.LBLoutput = new System.Windows.Forms.Label();
            this.NUDoffset = new System.Windows.Forms.NumericUpDown();
            this.LBLoffset = new System.Windows.Forms.Label();
            this.BTNencrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDoffset)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTinput
            // 
            this.TXTinput.Location = new System.Drawing.Point(264, 36);
            this.TXTinput.Multiline = true;
            this.TXTinput.Name = "TXTinput";
            this.TXTinput.Size = new System.Drawing.Size(231, 202);
            this.TXTinput.TabIndex = 0;
            // 
            // TXToutput
            // 
            this.TXToutput.Location = new System.Drawing.Point(264, 278);
            this.TXToutput.Multiline = true;
            this.TXToutput.Name = "TXToutput";
            this.TXToutput.Size = new System.Drawing.Size(231, 202);
            this.TXToutput.TabIndex = 1;
            // 
            // LBLinput
            // 
            this.LBLinput.AutoSize = true;
            this.LBLinput.Location = new System.Drawing.Point(264, 16);
            this.LBLinput.Name = "LBLinput";
            this.LBLinput.Size = new System.Drawing.Size(43, 17);
            this.LBLinput.TabIndex = 2;
            this.LBLinput.Text = "Input:";
            // 
            // LBLoutput
            // 
            this.LBLoutput.AutoSize = true;
            this.LBLoutput.Location = new System.Drawing.Point(264, 258);
            this.LBLoutput.Name = "LBLoutput";
            this.LBLoutput.Size = new System.Drawing.Size(55, 17);
            this.LBLoutput.TabIndex = 3;
            this.LBLoutput.Text = "Output:";
            // 
            // NUDoffset
            // 
            this.NUDoffset.Location = new System.Drawing.Point(13, 59);
            this.NUDoffset.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUDoffset.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.NUDoffset.Name = "NUDoffset";
            this.NUDoffset.Size = new System.Drawing.Size(197, 22);
            this.NUDoffset.TabIndex = 4;
            // 
            // LBLoffset
            // 
            this.LBLoffset.AutoSize = true;
            this.LBLoffset.Location = new System.Drawing.Point(12, 39);
            this.LBLoffset.Name = "LBLoffset";
            this.LBLoffset.Size = new System.Drawing.Size(50, 17);
            this.LBLoffset.TabIndex = 5;
            this.LBLoffset.Text = "Offset:";
            // 
            // BTNencrypt
            // 
            this.BTNencrypt.Location = new System.Drawing.Point(15, 305);
            this.BTNencrypt.Name = "BTNencrypt";
            this.BTNencrypt.Size = new System.Drawing.Size(195, 32);
            this.BTNencrypt.TabIndex = 6;
            this.BTNencrypt.Text = "Encrypt or Decrypt";
            this.BTNencrypt.UseVisualStyleBackColor = true;
            this.BTNencrypt.Click += new System.EventHandler(this.BTNencrypt_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 488);
            this.Controls.Add(this.BTNencrypt);
            this.Controls.Add(this.LBLoffset);
            this.Controls.Add(this.NUDoffset);
            this.Controls.Add(this.LBLoutput);
            this.Controls.Add(this.LBLinput);
            this.Controls.Add(this.TXToutput);
            this.Controls.Add(this.TXTinput);
            this.Name = "Form";
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.NUDoffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTinput;
        private System.Windows.Forms.TextBox TXToutput;
        private System.Windows.Forms.Label LBLinput;
        private System.Windows.Forms.Label LBLoutput;
        private System.Windows.Forms.NumericUpDown NUDoffset;
        private System.Windows.Forms.Label LBLoffset;
        private System.Windows.Forms.Button BTNencrypt;
    }
}

