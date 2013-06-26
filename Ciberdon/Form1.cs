using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ciberdon
{
    public partial class Form1 : Form
    {
        Dictionary<int, Folder> _carpetas = new Dictionary<int, Folder>();
        bool habilitar = true;
        public Form1()
        {
            InitializeComponent();
            this.Activate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _carpetas = CarpetaDAO.get(Application.StartupPath);
            cargarGrilla();
        }

        private void btnFolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dialog.SelectedPath;
            }
        }


        private void GrdViewFolders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();


            if (GrdViewFolders.Rows[e.RowIndex].Cells[0].Value != null)
                txtId.Text = GrdViewFolders.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                txtId.Text = "";

            if (GrdViewFolders.Rows[e.RowIndex].Cells[1].Value != null)
               TxtNombre.Text = GrdViewFolders.Rows[e.RowIndex].Cells[1].Value.ToString();
            else
                TxtNombre.Text = "";

            if (GrdViewFolders.Rows[e.RowIndex].Cells[3].Value!= null)
                txtFolder.Text = GrdViewFolders.Rows[e.RowIndex].Cells[3].Value.ToString();
            else
                txtFolder.Text = "";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea borrar el registro?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    int id = int.Parse(txtId.Text);

                    CarpetaDAO.delete(Application.StartupPath, id);
                    _carpetas.Remove(id);
                    cargarGrilla();
                    Limpiar();


                }
            }
        }

        private void cargarGrilla()
        {
            GrdViewFolders.AutoGenerateColumns = false;

            GrdViewFolders.Columns["ID"].DataPropertyName = "ID";
            GrdViewFolders.Columns["Nombre"].DataPropertyName = "Nombre";
            GrdViewFolders.Columns["Habilitada"].DataPropertyName = "Habilitada";
            GrdViewFolders.Columns["Habilitada"].ReadOnly = false;

            GrdViewFolders.Columns["Carpeta"].DataPropertyName = "Carpeta";

            GrdViewFolders.DataSource = _carpetas.Values.ToList();
        }

        private void BtnSaveFolder_Click(object sender, EventArgs e)
        {
            Folder c = new Folder();
            Boolean guardar = true;
            Boolean modificar = false;

            if (txtId.Text != "")
            {
                c.Id = int.Parse(txtId.Text);
                modificar = true;
            }


            if (txtFolder.Text.Trim() == "")
            {
                txtFolder.BackColor = Color.Red;
                guardar = false;
            }
            else
            {
                txtFolder.BackColor = Color.FromName("White");
                c.Carpeta = txtFolder.Text.Trim();
            }

            if (TxtNombre.Text.Trim() == "")
            {
                TxtNombre.BackColor = Color.Red;
                guardar = false;
            }
            else
            {
                TxtNombre.BackColor = Color.FromName("White");
                c.Nombre = TxtNombre.Text.Trim();
            }


            if (guardar)
            {
                if (modificar)
                {
                    c.Habilitada = _carpetas[c.Id].Habilitada;
                    CarpetaDAO.update(Application.StartupPath, c);
                    _carpetas[c.Id] = c;

                }
                else
                {
                    c.Habilitada = true;
                    c.Id = CarpetaDAO.insert(Application.StartupPath, c);
                    _carpetas.Add(c.Id, c);
                }

                cargarGrilla();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtId.BackColor = Color.FromName("Control");
            txtFolder.BackColor = Color.FromName("White");
            TxtNombre.BackColor = Color.FromName("White");

            txtId.Text = "";
            txtFolder.Text = "";
            TxtNombre.Text = "";

           
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            LblProgreso.Text = "";

            DialogResult dr = MessageBox.Show("Asegurese de que todas la computadoras seleccionadas no esten utilizandose. ¿Desea continuar con la Limpieza de archivos?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                BtnBorrar.Enabled = false;
                BtnEliminar.Enabled = false;
                btnFolderDialog.Enabled = false;
                BtnSaveFolder.Enabled = false;


                lblMensajes.Text = "";

                List<Folder> _obviar = CarpetaDAO.getObviar(Application.StartupPath).Values.ToList();

                int cant = 0;

                var carp=from c in _carpetas.Values.ToList()
                         where c.Habilitada==true
                         select c;

                foreach (Folder c in carp)
                {
                    Application.DoEvents();

                    LblProgreso.Text = cant.ToString() + " de " + carp.Count().ToString();

                    try
                    {
                        deleteDirectories(_obviar, c.Carpeta);
                    }
                    catch (Exception ex)
                    {
                        lblMensajes.Text = lblMensajes.Text + c.Nombre + " - " + ex.Message;
                    }

                    cant++;
                    LblProgreso.Text = cant.ToString() + " de " + carp.Count().ToString();

                }

                MessageBox.Show("Se completo la limpieza de archivos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                BtnBorrar.Enabled = true;
                BtnEliminar.Enabled = true;
                btnFolderDialog.Enabled = true;
                BtnSaveFolder.Enabled = true;

            }
        }

        private static void deleteDirectories(List<Folder> _obviar, string path)
        {
            string[] directories = Directory.GetDirectories(path);

            deleteFiles(path);

            foreach (string directory in directories)
            {

                DirectoryInfo di = new DirectoryInfo(directory);


                var obviar = from o in _obviar
                             where o.Carpeta.Trim().ToUpper() == di.Name.Trim().ToUpper()
                             select o.Carpeta;

                if (obviar.Count() == 0)
                {

                    deleteDirectories(_obviar, directory);
                    Directory.Delete(directory);
                }
                else
                {
                    deleteDirectories(_obviar, directory);

                    string[] directories2 = Directory.GetDirectories(directory);
                    foreach (string directory2 in directories2)
                    {
                        deleteFiles(directory2);
                    }
                }

            }
        }





        private static void deleteFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory);

            foreach (string file in files)
            {
                File.Delete(file);
            }
        }

        private void GrdViewFolders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                int id=0;
                if (GrdViewFolders.Rows[e.RowIndex].Cells[0].Value != null)
                    id = int.Parse( GrdViewFolders.Rows[e.RowIndex].Cells[0].Value.ToString());


                if (GrdViewFolders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    _carpetas[id].Habilitada = bool.Parse(GrdViewFolders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());


                CarpetaDAO.update(Application.StartupPath, _carpetas[id]);
            }

        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            foreach (Folder c in _carpetas.Values.ToList())
            {
                c.Habilitada = habilitar;
                CarpetaDAO.update(Application.StartupPath, c);

            }



            if (habilitar)
            {
                habilitar = false;
                BtnHabilitar.Text = "Deshabilitar Todos";
            }
            else
            {
                habilitar = true;
                BtnHabilitar.Text = "Habilitar Todos";
            }


            cargarGrilla();
        }



    }
}
