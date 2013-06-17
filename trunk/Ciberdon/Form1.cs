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
        Dictionary<int, Carpeta> _carpetas = new Dictionary<int, Carpeta>();

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

        private void BtnSaveFolder_Click(object sender, EventArgs e)
        {
            Carpeta c = new Carpeta();
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
                c.Path = txtFolder.Text.Trim();
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
            List<Carpeta> _obviar = CarpetaDAO.getObviar(Application.StartupPath).Values.ToList();


            foreach (Carpeta c in _carpetas.Values.ToList())
            {
                deleteDirectories(_obviar, c.Path);
            }
        }

        private static void deleteDirectories(List<Carpeta> _obviar, string path)
        {
            string[] directories = Directory.GetDirectories(path);

            deleteFiles(path);

            foreach (string directory in directories)
            {

                DirectoryInfo di = new DirectoryInfo(directory);
                

                var obviar = from o in _obviar
                             where o.Path.Trim().ToUpper() == di.Name.Trim().ToUpper()
                             select o.Path;

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

        private void GrdViewFolders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GrdViewFolders.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFolder.Text = GrdViewFolders.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        
    }
}
