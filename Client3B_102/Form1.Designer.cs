namespace Client3B_102
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btHitung = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // btHitung
            // 
            this.btHitung.Location = new System.Drawing.Point(551, 169);
            this.btHitung.Name = "btHitung";
            this.btHitung.Size = new System.Drawing.Size(75, 23);
            this.btHitung.TabIndex = 22;
            this.btHitung.Text = "Hitung Data";
            this.btHitung.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(551, 106);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(551, 44);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 20;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(341, 171);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngkatan.TabIndex = 19;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(341, 128);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxProdi.TabIndex = 18;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(341, 82);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 17;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(341, 44);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(100, 20);
            this.textBoxNIM.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "NIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btHitung);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btHitung;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

