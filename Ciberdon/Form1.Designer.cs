namespace Ciberdon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolderDialog = new System.Windows.Forms.Button();
            this.BtnSaveFolder = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.GrdViewFolders = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Carpeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblProgreso = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblMensajes = new System.Windows.Forms.TextBox();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFolderDialog, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSaveFolder, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GrdViewFolders, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnBorrar, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProgreso, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtNombre, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMensajes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnHabilitar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(200, 86);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(316, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFolderDialog
            // 
            this.btnFolderDialog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFolderDialog.Location = new System.Drawing.Point(522, 85);
            this.btnFolderDialog.Name = "btnFolderDialog";
            this.btnFolderDialog.Size = new System.Drawing.Size(25, 23);
            this.btnFolderDialog.TabIndex = 2;
            this.btnFolderDialog.Text = "...";
            this.btnFolderDialog.UseVisualStyleBackColor = true;
            this.btnFolderDialog.Click += new System.EventHandler(this.btnFolderDialog_Click);
            // 
            // BtnSaveFolder
            // 
            this.BtnSaveFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSaveFolder.Location = new System.Drawing.Point(571, 85);
            this.BtnSaveFolder.Name = "BtnSaveFolder";
            this.BtnSaveFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveFolder.TabIndex = 3;
            this.BtnSaveFolder.Text = "Guardar";
            this.BtnSaveFolder.UseVisualStyleBackColor = true;
            this.BtnSaveFolder.Click += new System.EventHandler(this.BtnSaveFolder_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtId.Location = new System.Drawing.Point(23, 86);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 4;
            // 
            // GrdViewFolders
            // 
            this.GrdViewFolders.AllowUserToAddRows = false;
            this.GrdViewFolders.AllowUserToDeleteRows = false;
            this.GrdViewFolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdViewFolders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdViewFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Habilitada,
            this.Carpeta});
            this.tableLayoutPanel1.SetColumnSpan(this.GrdViewFolders, 7);
            this.GrdViewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdViewFolders.Location = new System.Drawing.Point(3, 116);
            this.GrdViewFolders.MultiSelect = false;
            this.GrdViewFolders.Name = "GrdViewFolders";
            this.GrdViewFolders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdViewFolders.Size = new System.Drawing.Size(726, 215);
            this.GrdViewFolders.TabIndex = 0;
            this.GrdViewFolders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdViewFolders_CellDoubleClick);
            this.GrdViewFolders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdViewFolders_CellValueChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Habilitada
            // 
            this.Habilitada.Frozen = true;
            this.Habilitada.HeaderText = "Habilitada";
            this.Habilitada.Name = "Habilitada";
            this.Habilitada.Width = 60;
            // 
            // Carpeta
            // 
            this.Carpeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Carpeta.Frozen = true;
            this.Carpeta.HeaderText = "Carpeta";
            this.Carpeta.Name = "Carpeta";
            this.Carpeta.ReadOnly = true;
            this.Carpeta.Width = 69;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.Location = new System.Drawing.Point(273, 340);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(169, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Ejecutar Limpieza";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBorrar.Location = new System.Drawing.Point(656, 85);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(73, 23);
            this.BtnBorrar.TabIndex = 8;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ciberdon.Properties.Resources.ciberdon;
            this.pictureBox1.Location = new System.Drawing.Point(656, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LblProgreso
            // 
            this.LblProgreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblProgreso.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblProgreso, 2);
            this.LblProgreso.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgreso.ForeColor = System.Drawing.Color.Red;
            this.LblProgreso.Location = new System.Drawing.Point(571, 398);
            this.LblProgreso.Name = "LblProgreso";
            this.tableLayoutPanel1.SetRowSpan(this.LblProgreso, 2);
            this.LblProgreso.Size = new System.Drawing.Size(0, 21);
            this.LblProgreso.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox2, 3);
            this.pictureBox2.Image = global::Ciberdon.Properties.Resources.Header;
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(65, 86);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(129, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // lblMensajes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblMensajes, 3);
            this.lblMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajes.Location = new System.Drawing.Point(23, 372);
            this.lblMensajes.Multiline = true;
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.ReadOnly = true;
            this.lblMensajes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblMensajes.Size = new System.Drawing.Size(493, 108);
            this.lblMensajes.TabIndex = 11;
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnHabilitar, 2);
            this.BtnHabilitar.Location = new System.Drawing.Point(23, 340);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(125, 23);
            this.BtnHabilitar.TabIndex = 13;
            this.BtnHabilitar.Text = "Habilitar Todos";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ciberdon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView GrdViewFolders;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolderDialog;
        private System.Windows.Forms.Button BtnSaveFolder;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblProgreso;
        private System.Windows.Forms.TextBox lblMensajes;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carpeta;
        private System.Windows.Forms.Button BtnHabilitar;
    }
}

