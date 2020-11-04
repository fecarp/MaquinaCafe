namespace MaquinaCafe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.img1c = new System.Windows.Forms.PictureBox();
            this.img5c = new System.Windows.Forms.PictureBox();
            this.img10c = new System.Windows.Forms.PictureBox();
            this.img25c = new System.Windows.Forms.PictureBox();
            this.img50c = new System.Windows.Forms.PictureBox();
            this.img1r = new System.Windows.Forms.PictureBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdBebidas = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.Bebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img1c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img25c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img50c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1r)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // img1c
            // 
            this.img1c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img1c.Image = global::MaquinaCafe.Properties.Resources._1cent;
            this.img1c.Location = new System.Drawing.Point(213, 17);
            this.img1c.Name = "img1c";
            this.img1c.Size = new System.Drawing.Size(70, 70);
            this.img1c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1c.TabIndex = 0;
            this.img1c.TabStop = false;
            this.img1c.Click += new System.EventHandler(this.img1c_Click);
            // 
            // img5c
            // 
            this.img5c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img5c.Image = global::MaquinaCafe.Properties.Resources._5cent;
            this.img5c.Location = new System.Drawing.Point(299, 17);
            this.img5c.Name = "img5c";
            this.img5c.Size = new System.Drawing.Size(70, 70);
            this.img5c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img5c.TabIndex = 1;
            this.img5c.TabStop = false;
            this.img5c.Click += new System.EventHandler(this.img5c_Click);
            // 
            // img10c
            // 
            this.img10c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img10c.Image = global::MaquinaCafe.Properties.Resources._10cent;
            this.img10c.Location = new System.Drawing.Point(213, 98);
            this.img10c.Name = "img10c";
            this.img10c.Size = new System.Drawing.Size(70, 70);
            this.img10c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img10c.TabIndex = 2;
            this.img10c.TabStop = false;
            this.img10c.Click += new System.EventHandler(this.img10c_Click);
            // 
            // img25c
            // 
            this.img25c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img25c.Image = global::MaquinaCafe.Properties.Resources._25cent;
            this.img25c.Location = new System.Drawing.Point(299, 98);
            this.img25c.Name = "img25c";
            this.img25c.Size = new System.Drawing.Size(70, 70);
            this.img25c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img25c.TabIndex = 3;
            this.img25c.TabStop = false;
            this.img25c.Click += new System.EventHandler(this.img25c_Click);
            // 
            // img50c
            // 
            this.img50c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img50c.Image = global::MaquinaCafe.Properties.Resources._50cent;
            this.img50c.Location = new System.Drawing.Point(213, 179);
            this.img50c.Name = "img50c";
            this.img50c.Size = new System.Drawing.Size(70, 70);
            this.img50c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img50c.TabIndex = 4;
            this.img50c.TabStop = false;
            this.img50c.Click += new System.EventHandler(this.img50c_Click);
            // 
            // img1r
            // 
            this.img1r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img1r.Image = global::MaquinaCafe.Properties.Resources._1real;
            this.img1r.Location = new System.Drawing.Point(299, 179);
            this.img1r.Name = "img1r";
            this.img1r.Size = new System.Drawing.Size(80, 80);
            this.img1r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1r.TabIndex = 5;
            this.img1r.TabStop = false;
            this.img1r.Click += new System.EventHandler(this.img1r_Click);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(6, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(183, 65);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "0,00";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinheiro";
            // 
            // grdBebidas
            // 
            this.grdBebidas.AllowUserToAddRows = false;
            this.grdBebidas.AllowUserToDeleteRows = false;
            this.grdBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bebida,
            this.Preco});
            this.grdBebidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdBebidas.Location = new System.Drawing.Point(12, 102);
            this.grdBebidas.MultiSelect = false;
            this.grdBebidas.Name = "grdBebidas";
            this.grdBebidas.ReadOnly = true;
            this.grdBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBebidas.Size = new System.Drawing.Size(195, 147);
            this.grdBebidas.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(213, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Location = new System.Drawing.Point(12, 265);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(195, 34);
            this.btnCompra.TabIndex = 11;
            this.btnCompra.Text = "COMPRAR";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Bebida
            // 
            this.Bebida.Frozen = true;
            this.Bebida.HeaderText = "Bebida";
            this.Bebida.Name = "Bebida";
            this.Bebida.ReadOnly = true;
            // 
            // Preco
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preco.Frozen = true;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 311);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grdBebidas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.img1r);
            this.Controls.Add(this.img50c);
            this.Controls.Add(this.img25c);
            this.Controls.Add(this.img10c);
            this.Controls.Add(this.img5c);
            this.Controls.Add(this.img1c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Café";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img5c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img25c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img50c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1r)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img1c;
        private System.Windows.Forms.PictureBox img5c;
        private System.Windows.Forms.PictureBox img10c;
        private System.Windows.Forms.PictureBox img25c;
        private System.Windows.Forms.PictureBox img50c;
        private System.Windows.Forms.PictureBox img1r;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdBebidas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}

