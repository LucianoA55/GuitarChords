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
    public partial class frmInicial : Form
    {
        AccesoDatos datos = new AccesoDatos();
        const int c = 10000;
        Partituras[] vp = new Partituras[c];
        public frmInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista("Select * From Partituras Order by 2");
            cargarCombo(cbogenero, "Generos", "Order by 2");
            cargarCombo(cboautor, "Autores", "Order by 2");
            cboautor.SelectedIndex = -1;
            cbogenero.SelectedIndex = -1;
            txtcapo.Enabled = false;
        }
        private void cargarCombo(ComboBox combo, string nombreTabla, string condicion)
        {
            DataTable dt = new DataTable();
            dt = datos.ConsultarTabla(nombreTabla, condicion);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }
        private void Limpiar()
        {
            txtnombre.Text = "";
            txtpartitura.Text = "";
            cboautor.SelectedIndex = -1;
            cbogenero.SelectedIndex = -1;
            rbtno.Checked = false;
            rbtsi.Checked = false;
            txtpartitura2.Text = "";

        }
        private void cargarLista(string sql)
        {
            int c = 0;
            datos.LeerTabla2(sql);
            while (datos.pLector.Read())
            {
                Partituras P = new Partituras();
                if (!datos.pLector.IsDBNull(0))
                    P.pId_partitura = datos.pLector.GetInt32(0);
                if (!datos.pLector.IsDBNull(1))
                    P.pNombre_cancion = datos.pLector.GetString(1);
                if (!datos.pLector.IsDBNull(2))
                    P.pCapotrasto = datos.pLector.GetInt32(2);
                P.pCapotrasto = datos.pLector.GetInt32(2);
                P.pCapotrasto = datos.pLector.GetInt32(2);
                if (!datos.pLector.IsDBNull(3))
                    P.pPosicion_capo = datos.pLector.GetInt32(3);
                if (!datos.pLector.IsDBNull(4))
                    P.pLetra1 = datos.pLector.GetString(4);
                if (!datos.pLector.IsDBNull(5))
                    P.pLetra2 = datos.pLector.GetString(5);
                if (!datos.pLector.IsDBNull(6))
                    P.pId_genero = datos.pLector.GetInt32(6);
                if (!datos.pLector.IsDBNull(7))
                    P.pId_autor = datos.pLector.GetInt32(7);
                vp[c] = P;
                c++;
            }
            datos.pLector.Close();
            datos.desconectar();
            lstpartitura.Items.Clear();
            for (int i = 0; i < c; i++)
                lstpartitura.Items.Add(vp[i].toString());
            lstpartitura.SelectedIndex = -1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCancion ac = new frmAgregarCancion();
            ac.ShowDialog();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros G = new frmGeneros();
            G.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores A = new frmAutores();
            A.ShowDialog();
        }

        private void btmcargarLista_Click(object sender, EventArgs e)
        {
            string parametro1 = "";
            if (txtnombre.Text != "")
                parametro1 = txtnombre.Text;
            string parametro2 = "";
            if (rbtno.Checked == true)
                parametro2 = "0";
            else
                if (rbtsi.Checked == true)
                parametro2 = "1";
            string parametro3 = "";
            if (cbogenero.SelectedIndex != -1)
                parametro3 = Convert.ToString(cbogenero.SelectedValue);
            string parametro4 = "";
            if (cboautor.SelectedIndex != -1)
                parametro4 = Convert.ToString(cboautor.SelectedValue);
            string sql = "Select * from Partituras where 1=1 ";
            if (parametro1 != "")
                sql += "and nombre_cancion COLLATE SQL_Latin1_General_Cp1_CI_AI like '" + parametro1+"%'";
            if (parametro2 != "")
                sql += "and capotrasto=" + parametro2;
            if (parametro3 != "")
                sql += "and id_genero=" + parametro3;
            if (parametro4 != "")
                sql += "and id_autor=" + parametro4;
            sql += "order by nombre_cancion";
            lstpartitura.Items.Clear();
            cargarLista(sql) ;
            Limpiar();
        }

        private void lstpartitura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = lstpartitura.SelectedIndex;
            txtcapo.Text = Convert.ToString(vp[c].pPosicion_capo);
            txtpartitura.Text = vp[c].pLetra1;
            txtpartitura2.Text = vp[c].pLetra2;
            txtnombre.Text = vp[c].pNombre_cancion;
            cboautor.SelectedValue = vp[c].pId_autor;
            cbogenero.SelectedValue = vp[c].pId_genero;
            if (vp[c].pCapotrasto == 0)
                rbtno.Checked = true;
            else
                if (vp[c].pCapotrasto == 1)
                rbtsi.Checked = true;

        }

        private void btmlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
