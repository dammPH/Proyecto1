using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDatos;
using ModeloDominio;

namespace DISCOSv3
{
    public partial class Form1 : Form
    {
        private List<Disco> listadiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoData discodata = new DiscoData();
            listadiscos = discodata.Listar();
            dgvDiscos.DataSource = listadiscos;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            pbxDiscoPortada.Load(listadiscos[0].UrlImagen);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
           Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
           pbxDiscoPortada.Load(seleccionado.UrlImagen);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmagregar = new frmAgregar();
            frmagregar.ShowDialog();
        }
    }
}
