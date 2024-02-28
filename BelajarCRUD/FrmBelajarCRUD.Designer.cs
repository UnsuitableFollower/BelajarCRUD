namespace BelajarCRUD
{
    partial class FrmBelajarCRUD
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
            dgvCRUD = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnHapus = new Button();
            btnUbah = new Button();
            btnSimpan = new Button();
            btnCari = new Button();
            pbGambar = new PictureBox();
            txtDeskripsi = new TextBox();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCRUD).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // dgvCRUD
            // 
            dgvCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCRUD.Location = new Point(346, 114);
            dgvCRUD.Name = "dgvCRUD";
            dgvCRUD.RowTemplate.Height = 25;
            dgvCRUD.Size = new Size(442, 324);
            dgvCRUD.TabIndex = 16;
            dgvCRUD.CellContentClick += dgvCRUD_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 84);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(548, 38);
            label1.TabIndex = 0;
            label1.Text = "Belajar CRUD (Create, Read, Update Delete)";
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(248, 401);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 37);
            btnHapus.TabIndex = 21;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(167, 401);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 37);
            btnUbah.TabIndex = 20;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(86, 401);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 37);
            btnSimpan.TabIndex = 19;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(231, 355);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(92, 29);
            btnCari.TabIndex = 18;
            btnCari.Text = "Pilih Gambar";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // pbGambar
            // 
            pbGambar.BackColor = SystemColors.AppWorkspace;
            pbGambar.Location = new Point(136, 185);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(187, 155);
            pbGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGambar.TabIndex = 17;
            pbGambar.TabStop = false;
            pbGambar.Click += pbGambar_Click;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(136, 140);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(187, 23);
            txtDeskripsi.TabIndex = 15;
            txtDeskripsi.TextChanged += txtDeskripsi_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(136, 108);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(187, 23);
            txtNama.TabIndex = 14;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 138);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 13;
            label3.Text = "Deskripsi          :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 110);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 12;
            label2.Text = "Nama Barang  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 185);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 22;
            label4.Text = "Gambar            :";
            label4.Click += label4_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 223);
            txtId.Name = "txtId";
            txtId.Size = new Size(32, 23);
            txtId.TabIndex = 23;
            // 
            // FrmBelajarCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(dgvCRUD);
            Controls.Add(panel1);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(btnCari);
            Controls.Add(pbGambar);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmBelajarCRUD";
            Text = "FrmBelajarCRUD";
            Load += FrmBelajarCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCRUD).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCRUD;
        private Panel panel1;
        private Label label1;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnSimpan;
        private Button btnCari;
        private PictureBox pbGambar;
        private TextBox txtDeskripsi;
        private TextBox txtNama;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtId;
    }
}