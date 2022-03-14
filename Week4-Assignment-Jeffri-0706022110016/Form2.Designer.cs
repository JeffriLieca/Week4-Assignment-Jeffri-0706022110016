
namespace Week4_Assignment_Jeffri_0706022110016
{
    partial class FormTampilanData
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
            this.tBTelp2 = new System.Windows.Forms.TextBox();
            this.tBAlamat2 = new System.Windows.Forms.TextBox();
            this.tBNama2 = new System.Windows.Forms.TextBox();
            this.buttonPrevData = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.labelTelp2 = new System.Windows.Forms.Label();
            this.labelAlamat2 = new System.Windows.Forms.Label();
            this.labelNama2 = new System.Windows.Forms.Label();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBTelp2
            // 
            this.tBTelp2.Location = new System.Drawing.Point(116, 114);
            this.tBTelp2.Name = "tBTelp2";
            this.tBTelp2.Size = new System.Drawing.Size(152, 27);
            this.tBTelp2.TabIndex = 15;
            // 
            // tBAlamat2
            // 
            this.tBAlamat2.Location = new System.Drawing.Point(116, 69);
            this.tBAlamat2.Name = "tBAlamat2";
            this.tBAlamat2.Size = new System.Drawing.Size(513, 27);
            this.tBAlamat2.TabIndex = 14;
            // 
            // tBNama2
            // 
            this.tBNama2.Location = new System.Drawing.Point(116, 18);
            this.tBNama2.Name = "tBNama2";
            this.tBNama2.Size = new System.Drawing.Size(310, 27);
            this.tBNama2.TabIndex = 13;
            // 
            // buttonPrevData
            // 
            this.buttonPrevData.Location = new System.Drawing.Point(174, 166);
            this.buttonPrevData.Name = "buttonPrevData";
            this.buttonPrevData.Size = new System.Drawing.Size(94, 29);
            this.buttonPrevData.TabIndex = 12;
            this.buttonPrevData.Text = "Prev Data";
            this.buttonPrevData.UseVisualStyleBackColor = true;
            this.buttonPrevData.Click += new System.EventHandler(this.buttonPrevData_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(36, 166);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(94, 29);
            this.buttonKembali.TabIndex = 11;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // labelTelp2
            // 
            this.labelTelp2.AutoSize = true;
            this.labelTelp2.Location = new System.Drawing.Point(36, 114);
            this.labelTelp2.Name = "labelTelp2";
            this.labelTelp2.Size = new System.Drawing.Size(40, 20);
            this.labelTelp2.TabIndex = 10;
            this.labelTelp2.Text = "Telp:";
            // 
            // labelAlamat2
            // 
            this.labelAlamat2.AutoSize = true;
            this.labelAlamat2.Location = new System.Drawing.Point(36, 69);
            this.labelAlamat2.Name = "labelAlamat2";
            this.labelAlamat2.Size = new System.Drawing.Size(60, 20);
            this.labelAlamat2.TabIndex = 9;
            this.labelAlamat2.Text = "Alamat:";
            // 
            // labelNama2
            // 
            this.labelNama2.AutoSize = true;
            this.labelNama2.Location = new System.Drawing.Point(36, 25);
            this.labelNama2.Name = "labelNama2";
            this.labelNama2.Size = new System.Drawing.Size(52, 20);
            this.labelNama2.TabIndex = 8;
            this.labelNama2.Text = "Nama:";
            // 
            // buttonNextData
            // 
            this.buttonNextData.Location = new System.Drawing.Point(309, 166);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(94, 29);
            this.buttonNextData.TabIndex = 16;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            this.buttonNextData.Click += new System.EventHandler(this.buttonNextData_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 237);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.tBTelp2);
            this.Controls.Add(this.tBAlamat2);
            this.Controls.Add(this.tBNama2);
            this.Controls.Add(this.buttonPrevData);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.labelTelp2);
            this.Controls.Add(this.labelAlamat2);
            this.Controls.Add(this.labelNama2);
            this.Name = "FormTampilanData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBTelp2;
        private System.Windows.Forms.TextBox tBAlamat2;
        private System.Windows.Forms.TextBox tBNama2;
        private System.Windows.Forms.Button buttonPrevData;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Label labelTelp2;
        private System.Windows.Forms.Label labelAlamat2;
        private System.Windows.Forms.Label labelNama2;
        private System.Windows.Forms.Button buttonNextData;
    }
}