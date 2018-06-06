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
    public partial class frmAutores : Form
    {
        AccesoDatos datos = new AccesoDatos();
        Autores A = new Autores();
        public frmAutores()
        {
            InitializeComponent();
        }

        private void btmagregar_Click(object sender, EventArgs e)
        {
            {
                string sql = "";
                if (txtautor.Text != "")
                {
                    A.pNombre_autor = txtautor.Text;
                    sql = "Insert Into Autores Values('" + A.pNombre_autor + "')";
                    datos.actualizarDB(sql);
                }
                else
                    MessageBox.Show("Ingrese un Autor...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtautor.Text = "";
            }
        }
    }
}
