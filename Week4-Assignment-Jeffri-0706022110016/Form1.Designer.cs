
namespace Week4_Assignment_Jeffri_0706022110016
{
    partial class FormPenambahanData
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
            this.labelNama1 = new System.Windows.Forms.Label();
            this.labelAlamat1 = new System.Windows.Forms.Label();
            this.labelTelp1 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihatData = new System.Windows.Forms.Button();
            this.tBNama1 = new System.Windows.Forms.TextBox();
            this.tBAlamat1 = new System.Windows.Forms.TextBox();
            this.tBTelp1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNama1
            // 
            this.labelNama1.AutoSize = true;
            this.labelNama1.Location = new System.Drawing.Point(36, 22);
            this.labelNama1.Name = "labelNama1";
            this.labelNama1.Size = new System.Drawing.Size(52, 20);
            this.labelNama1.TabIndex = 0;
            this.labelNama1.Text = "Nama:";
            // 
            // labelAlamat1
            // 
            this.labelAlamat1.AutoSize = true;
            this.labelAlamat1.Location = new System.Drawing.Point(36, 66);
            this.labelAlamat1.Name = "labelAlamat1";
            this.labelAlamat1.Size = new System.Drawing.Size(60, 20);
            this.labelAlamat1.TabIndex = 1;
            this.labelAlamat1.Text = "Alamat:";
            // 
            // labelTelp1
            // 
            this.labelTelp1.AutoSize = true;
            this.labelTelp1.Location = new System.Drawing.Point(36, 111);
            this.labelTelp1.Name = "labelTelp1";
            this.labelTelp1.Size = new System.Drawing.Size(40, 20);
            this.labelTelp1.TabIndex = 2;
            this.labelTelp1.Text = "Telp:";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(36, 163);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(94, 29);
            this.buttonSimpan.TabIndex = 3;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihatData
            // 
            this.buttonLihatData.Location = new System.Drawing.Point(174, 163);
            this.buttonLihatData.Name = "buttonLihatData";
            this.buttonLihatData.Size = new System.Drawing.Size(94, 29);
            this.buttonLihatData.TabIndex = 4;
            this.buttonLihatData.Text = "Lihat Data";
            this.buttonLihatData.UseVisualStyleBackColor = true;
            this.buttonLihatData.Click += new System.EventHandler(this.buttonLihatData_Click);
            // 
            // tBNama1
            // 
            this.tBNama1.Location = new System.Drawing.Point(116, 15);
            this.tBNama1.Name = "tBNama1";
            this.tBNama1.Size = new System.Drawing.Size(310, 27);
            this.tBNama1.TabIndex = 5;
            // 
            // tBAlamat1
            // 
            this.tBAlamat1.Location = new System.Drawing.Point(116, 66);
            this.tBAlamat1.Name = "tBAlamat1";
            this.tBAlamat1.Size = new System.Drawing.Size(513, 27);
            this.tBAlamat1.TabIndex = 6;
            // 
            // tBTelp1
            // 
            this.tBTelp1.Location = new System.Drawing.Point(116, 111);
            this.tBTelp1.Name = "tBTelp1";
            this.tBTelp1.Size = new System.Drawing.Size(152, 27);
            this.tBTelp1.TabIndex = 7;
            this.tBTelp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBTelp1_KeyPress);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 237);
            this.Controls.Add(this.tBTelp1);
            this.Controls.Add(this.tBAlamat1);
            this.Controls.Add(this.tBNama1);
            this.Controls.Add(this.buttonLihatData);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelTelp1);
            this.Controls.Add(this.labelAlamat1);
            this.Controls.Add(this.labelNama1);
            this.Name = "FormPenambahanData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama1;
        private System.Windows.Forms.Label labelAlamat1;
        private System.Windows.Forms.Label labelTelp1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonLihatData;
        private System.Windows.Forms.TextBox tBNama1;
        private System.Windows.Forms.TextBox tBAlamat1;
        private System.Windows.Forms.TextBox tBTelp1;
    }
}

