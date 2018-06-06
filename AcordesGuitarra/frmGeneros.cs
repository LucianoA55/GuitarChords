using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcordesGuitarra
{
    public partial class frmGeneros : Form
    {
        AccesoDatos datos = new AccesoDatos();
        Generos G = new Generos();
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void btmagregar_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtgenero.Text != "")
            {
                G.pNombre_genero = txtgenero.Text;
                sql = "Insert Into Generos Values('" + G.pNombre_genero + "')";
                datos.actualizarDB(sql);
            }
            else
                MessageBox.Show("Ingrese un Genero...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtgenero.Text = "";
        }
    }
}
