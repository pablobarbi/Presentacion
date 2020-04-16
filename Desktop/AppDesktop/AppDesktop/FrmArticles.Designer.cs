namespace AppDesktop
{
    partial class FrmArticles
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
            this.gbManager = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.LblStore = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotalInVault = new System.Windows.Forms.TextBox();
            this.txtTotalInShelf = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTotalInVault = new System.Windows.Forms.Label();
            this.lblTotalInShelf = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgArticles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManager
            // 
            this.gbManager.Controls.Add(this.txtId);
            this.gbManager.Controls.Add(this.cbStore);
            this.gbManager.Controls.Add(this.LblStore);
            this.gbManager.Controls.Add(this.btnAceptar);
            this.gbManager.Controls.Add(this.btnCancelar);
            this.gbManager.Controls.Add(this.txtTotalInVault);
            this.gbManager.Controls.Add(this.txtTotalInShelf);
            this.gbManager.Controls.Add(this.txtPrice);
            this.gbManager.Controls.Add(this.txtName);
            this.gbManager.Controls.Add(this.txtDescription);
            this.gbManager.Controls.Add(this.lblTotalInVault);
            this.gbManager.Controls.Add(this.lblTotalInShelf);
            this.gbManager.Controls.Add(this.lblPrice);
            this.gbManager.Controls.Add(this.lblDescription);
            this.gbManager.Controls.Add(this.lblName);
            this.gbManager.Location = new System.Drawing.Point(80, 12);
            this.gbManager.Name = "gbManager";
            this.gbManager.Size = new System.Drawing.Size(671, 271);
            this.gbManager.TabIndex = 0;
            this.gbManager.TabStop = false;
            this.gbManager.Text = "Manager";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(500, 122);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(165, 21);
            this.cbStore.TabIndex = 13;
            // 
            // LblStore
            // 
            this.LblStore.AutoSize = true;
            this.LblStore.Location = new System.Drawing.Point(438, 122);
            this.LblStore.Name = "LblStore";
            this.LblStore.Size = new System.Drawing.Size(32, 13);
            this.LblStore.TabIndex = 12;
            this.LblStore.Text = "Store";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(378, 200);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(148, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotalInVault
            // 
            this.txtTotalInVault.Location = new System.Drawing.Point(500, 75);
            this.txtTotalInVault.Name = "txtTotalInVault";
            this.txtTotalInVault.Size = new System.Drawing.Size(100, 20);
            this.txtTotalInVault.TabIndex = 9;
            this.txtTotalInVault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalInVault_KeyPress);
            // 
            // txtTotalInShelf
            // 
            this.txtTotalInShelf.Location = new System.Drawing.Point(500, 31);
            this.txtTotalInShelf.Name = "txtTotalInShelf";
            this.txtTotalInShelf.Size = new System.Drawing.Size(100, 20);
            this.txtTotalInShelf.TabIndex = 8;
            this.txtTotalInShelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalInShelf_KeyPress_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(82, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(82, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 34);
            this.txtDescription.TabIndex = 5;
            // 
            // lblTotalInVault
            // 
            this.lblTotalInVault.AutoSize = true;
            this.lblTotalInVault.Location = new System.Drawing.Point(426, 78);
            this.lblTotalInVault.Name = "lblTotalInVault";
            this.lblTotalInVault.Size = new System.Drawing.Size(70, 13);
            this.lblTotalInVault.TabIndex = 4;
            this.lblTotalInVault.Text = "Total In Vault";
            // 
            // lblTotalInShelf
            // 
            this.lblTotalInShelf.AutoSize = true;
            this.lblTotalInShelf.Location = new System.Drawing.Point(423, 31);
            this.lblTotalInShelf.Name = "lblTotalInShelf";
            this.lblTotalInShelf.Size = new System.Drawing.Size(70, 13);
            this.lblTotalInShelf.TabIndex = 3;
            this.lblTotalInShelf.Text = "Total In Shelf";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(34, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // dgArticles
            // 
            this.dgArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticles.Location = new System.Drawing.Point(80, 318);
            this.dgArticles.Name = "dgArticles";
            this.dgArticles.Size = new System.Drawing.Size(671, 150);
            this.dgArticles.TabIndex = 1;
            this.dgArticles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArticles_CellDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(638, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(80, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgArticles);
            this.Controls.Add(this.gbManager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.gbManager.ResumeLayout(false);
            this.gbManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).EndInit();
            this.ResumeLayout(false);

        }

        private void TxtTotalInShelf_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbManager;
        private System.Windows.Forms.Label lblTotalInShelf;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotalInVault;
        private System.Windows.Forms.TextBox txtTotalInShelf;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTotalInVault;
        private System.Windows.Forms.DataGridView dgArticles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label LblStore;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
    }
}