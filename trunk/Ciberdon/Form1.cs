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

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _carpetas =CarpetaDAO.get(Application.StartupPath);
            GrdViewFolders.DataSource = _carpetas.Values.ToList();
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
            txtId.Text = GrdViewFolders.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFolder.Text = GrdViewFolders.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea borrar el registro?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

          if (dr == System.Windows.Forms.DialogResult.OK)
          {
              if (txtId.Text != "")
              {
                  int id = int.Parse(txtId.Text);



                  CarpetaDAO.delete(Application.StartupPath, id);
                  _carpetas.Remove(id);
                  GrdViewFolders.DataSource = _carpetas.Values.ToList();
                  Limpiar();

              }
          }
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
                txtFolder.BackColor = Color.FromName("Control");
                c.Carpeta = txtFolder.Text.Trim();
            }


            if (guardar)
            {
                if (modificar)
                {
                    CarpetaDAO.update(Application.StartupPath, c);
                    _carpetas[c.Id] = c;

                }
                else
                {
                    c.Id = CarpetaDAO.insert(Application.StartupPath, c);
                    _carpetas.Add(c.Id, c);
                }

                GrdViewFolders.DataSource = _carpetas.Values.ToList();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtId.BackColor = Color.FromName("Control");
            txtFolder.BackColor = Color.FromName("Control");
            txtId.Text = "";
            txtFolder.Text = "";

            GrdViewFolders.DataSource = _carpetas.Values.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            LblProgreso.Text = "";

             DialogResult dr= MessageBox.Show("Asegurese de que todas la computadoras seleccionadas no esten utilizandose. ¿Desea continuar con la Limpieza de archivos?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

             if (dr == System.Windows.Forms.DialogResult.OK)
             {

                 BtnBorrar.Enabled = false;
                 BtnEliminar.Enabled = false;
                 btnFolderDialog.Enabled = false;
                 BtnSaveFolder.Enabled = false;


                 lblMensajes.Text = "";

                 List<Folder> _obviar = CarpetaDAO.getObviar(Application.StartupPath).Values.ToList();

                 int cant = 0;
                 foreach (Folder c in _carpetas.Values.ToList())
                 {
                     Application.DoEvents();
                     
                     LblProgreso.Text =cant.ToString() + " de " + _carpetas.Values.ToList().Count.ToString();

                     try
                     {
                         deleteDirectories(_obviar, c.Carpeta);
                     }
                     catch (Exception ex)
                     {
                         lblMensajes.Text = lblMensajes.Text + " - " + ex.Message;
                     }

                     cant++;
                     LblProgreso.Text = cant.ToString() + " de " + _carpetas.Values.ToList().Count.ToString();

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



        
    }
}
