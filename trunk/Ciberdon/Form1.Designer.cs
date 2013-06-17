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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrdViewFolders = new System.Windows.Forms.DataGridView();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolderDialog = new System.Windows.Forms.Button();
            this.BtnSaveFolder = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.9779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Controls.Add(this.GrdViewFolders, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFolderDialog, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSaveFolder, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GrdViewFolders
            // 
            this.GrdViewFolders.AllowUserToAddRows = false;
            this.GrdViewFolders.AllowUserToDeleteRows = false;
            this.GrdViewFolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdViewFolders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdViewFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.GrdViewFolders, 2);
            this.GrdViewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdViewFolders.Location = new System.Drawing.Point(106, 93);
            this.GrdViewFolders.MultiSelect = false;
            this.GrdViewFolders.Name = "GrdViewFolders";
            this.GrdViewFolders.ReadOnly = true;
            this.GrdViewFolders.Size = new System.Drawing.Size(363, 179);
            this.GrdViewFolders.TabIndex = 0;
            this.GrdViewFolders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdViewFolders_CellDoubleClick);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(106, 62);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(328, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFolderDialog
            // 
            this.btnFolderDialog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFolderDialog.Location = new System.Drawing.Point(440, 61);
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
            this.BtnSaveFolder.Location = new System.Drawing.Point(475, 61);
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
            this.txtId.Location = new System.Drawing.Point(43, 62);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 4;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(106, 278);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 329);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Ciberdon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewFolders)).EndInit();
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
    }
}

