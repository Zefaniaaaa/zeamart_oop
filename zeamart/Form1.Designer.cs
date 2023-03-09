namespace zeamart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            t_id = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            t_search = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            t_nama = new TextBox();
            t_berat = new TextBox();
            t_kadaluarsa = new TextBox();
            t_harga = new TextBox();
            p_image = new PictureBox();
            b_browse = new Button();
            b_save = new Button();
            b_edit = new Button();
            b_delete = new Button();
            label6 = new Label();
            t_stok = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 261);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 314);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "berat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 369);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "kadaluarsa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 425);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 3;
            label4.Text = "harga";
            // 
            // t_id
            // 
            t_id.Location = new Point(526, 165);
            t_id.Name = "t_id";
            t_id.Size = new Size(85, 31);
            t_id.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(t_search);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(t_id);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 236);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(920, 164);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // t_search
            // 
            t_search.Location = new Point(710, 165);
            t_search.Name = "t_search";
            t_search.Size = new Size(242, 31);
            t_search.TabIndex = 18;
            t_search.TextChanged += t_search_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 168);
            label5.Name = "label5";
            label5.Size = new Size(27, 25);
            label5.TabIndex = 11;
            label5.Text = "id";
            // 
            // t_nama
            // 
            t_nama.Location = new Point(228, 258);
            t_nama.Name = "t_nama";
            t_nama.Size = new Size(243, 31);
            t_nama.TabIndex = 7;
            // 
            // t_berat
            // 
            t_berat.Location = new Point(228, 311);
            t_berat.Name = "t_berat";
            t_berat.Size = new Size(243, 31);
            t_berat.TabIndex = 8;
            // 
            // t_kadaluarsa
            // 
            t_kadaluarsa.Location = new Point(228, 366);
            t_kadaluarsa.Name = "t_kadaluarsa";
            t_kadaluarsa.Size = new Size(243, 31);
            t_kadaluarsa.TabIndex = 9;
            // 
            // t_harga
            // 
            t_harga.Location = new Point(228, 422);
            t_harga.Name = "t_harga";
            t_harga.Size = new Size(243, 31);
            t_harga.TabIndex = 10;
            // 
            // p_image
            // 
            p_image.BackColor = SystemColors.ControlLightLight;
            p_image.Location = new Point(616, 252);
            p_image.Name = "p_image";
            p_image.Size = new Size(170, 198);
            p_image.SizeMode = PictureBoxSizeMode.StretchImage;
            p_image.TabIndex = 12;
            p_image.TabStop = false;
            // 
            // b_browse
            // 
            b_browse.Location = new Point(616, 460);
            b_browse.Name = "b_browse";
            b_browse.Size = new Size(170, 40);
            b_browse.TabIndex = 13;
            b_browse.Text = "browse";
            b_browse.UseVisualStyleBackColor = true;
            b_browse.Click += b_browse_Click;
            // 
            // b_save
            // 
            b_save.Location = new Point(883, 270);
            b_save.Name = "b_save";
            b_save.Size = new Size(128, 70);
            b_save.TabIndex = 14;
            b_save.Text = "save";
            b_save.UseVisualStyleBackColor = true;
            b_save.Click += b_save_Click;
            // 
            // b_edit
            // 
            b_edit.Location = new Point(883, 346);
            b_edit.Name = "b_edit";
            b_edit.Size = new Size(128, 70);
            b_edit.TabIndex = 15;
            b_edit.Text = "edit";
            b_edit.UseVisualStyleBackColor = true;
            b_edit.Click += b_edit_Click;
            // 
            // b_delete
            // 
            b_delete.Location = new Point(883, 422);
            b_delete.Name = "b_delete";
            b_delete.Size = new Size(128, 70);
            b_delete.TabIndex = 16;
            b_delete.Text = "delete";
            b_delete.UseVisualStyleBackColor = true;
            b_delete.Click += b_delete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 475);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 18;
            label6.Text = "stok";
            // 
            // t_stok
            // 
            t_stok.Location = new Point(228, 476);
            t_stok.Name = "t_stok";
            t_stok.Size = new Size(243, 31);
            t_stok.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 528);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1097, 510);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 63;
            // 
            // Column2
            // 
            Column2.HeaderText = "nama";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "berat";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "kadaluarsa";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "harga";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "stok";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "gambar";
            Column7.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 1050);
            Controls.Add(dataGridView1);
            Controls.Add(t_stok);
            Controls.Add(label6);
            Controls.Add(b_delete);
            Controls.Add(b_edit);
            Controls.Add(b_save);
            Controls.Add(b_browse);
            Controls.Add(p_image);
            Controls.Add(t_harga);
            Controls.Add(t_kadaluarsa);
            Controls.Add(t_berat);
            Controls.Add(t_nama);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox t_id;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox t_search;
        private PictureBox pictureBox1;
        private TextBox t_nama;
        private TextBox t_berat;
        private TextBox t_kadaluarsa;
        private TextBox t_harga;
        private Label label5;
        private PictureBox p_image;
        private Button b_browse;
        private Button b_save;
        private Button b_edit;
        private Button b_delete;
        private Label label6;
        private TextBox t_stok;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
    }
}