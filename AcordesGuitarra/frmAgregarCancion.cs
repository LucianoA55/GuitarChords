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
    public partial class frmAgregarCancion : Form
    {
        AccesoDatos datos = new AccesoDatos();
        const int c = 10000;
        Partituras[] vp = new Partituras[c];
        bool nuevo = false;
        public frmAgregarCancion()
        {
            InitializeComponent();
        }
        private void cargarCombo(ComboBox combo,string nombreTabla,string condicion)
        {
            DataTable dt = new DataTable();
            dt = datos.ConsultarTabla(nombreTabla,condicion);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }
        private void Habilitar(bool x)
        {
            txtcapo.Enabled = !x;
            txtnombre.Enabled = !x;
            txtpartitura.Enabled = !x;
            txtpartitura2.Enabled = !x;
            cbogenero.Enabled = !x;
            cboautor.Enabled = !x;
            rbtno.Enabled = !x;
            rbtsi.Enabled = !x;
            btmborrar.Enabled = x;
            btmcancelar.Enabled = x;
            btmeditar.Enabled = x;
            btmguardar.Enabled = !x;
            btmnuevo.Enabled = x;
        }
        private void cargarLista(string nombreTabla,string condicion)
        {
            int c = 0;
            datos.LeerTabla(nombreTabla,condicion);
            while(datos.pLector.Read())
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
            lstpartitura.SelectedIndex = 0;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Escriba el nombre de la Canción...",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                txtnombre.Focus();
                return false;
            }
            if(!rbtno.Checked&&!rbtsi.Checked)
            {
                MessageBox.Show("Especifique si usa Capotrasto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtno.Focus();
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            txtcapo.Text = "";
            txtnombre.Text = "";
            txtpartitura.Text = "";
            cboautor.SelectedIndex = -1;
            cbogenero.SelectedIndex = -1;
            rbtno.Checked = false;
            rbtsi.Checked = false;
            txtpartitura2.Text = "";

        }

        private void frmAgregarCancion_Load(object sender, EventArgs e)
        {
            cargarCombo(cbogenero, "Generos","order by 2");
            cargarCombo(cboautor, "Autores","order by 2");
            cargarLista("Partituras","order by 2");
            Habilitar(true);
            Limpiar();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            btmcancelar.Enabled = true;
            lstpartitura.Enabled = false;
            nuevo = true;
            txtcapo.Text = "0";
        }
      
        private void btmguardar_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                string sql = "";
                if(nuevo==true)
                {
                    Partituras Pa = new Partituras();
                    Pa.pNombre_cancion = txtnombre.Text;
                    if (rbtno.Checked)
                        Pa.pCapotrasto = 0;
                    else
                        if (rbtsi.Checked)
                        Pa.pCapotrasto = 1;
                    Pa.pPosicion_capo = Convert.ToInt32(txtcapo.Text);
                    Pa.pLetra1 = txtpartitura.Text;
                    Pa.pLetra2 = txtpartitura2.Text;
                    Pa.pId_genero = Convert.ToInt32(cbogenero.SelectedValue);
                    Pa.pId_autor = Convert.ToInt32(cboautor.SelectedValue);
                    sql = "Insert into Partituras Values('" + Pa.pNombre_cancion.Replace("'", "''") + "'," + Pa.pCapotrasto + "," + Pa.pPosicion_capo +
                        ",'" + Pa.pLetra1.Replace("'","''") + "','"+Pa.pLetra2.Replace("'", "''") + "'," + Pa.pId_genero + "," + Pa.pId_autor + ")";

                    nuevo = false;          
                }
                else 
                {   
                    int i = lstpartitura.SelectedIndex;
                    vp[i].pNombre_cancion = txtnombre.Text;
                    if (rbtno.Checked)
                        vp[i].pCapotrasto = 0;
                    else
                      if (rbtsi.Checked)
                        vp[i].pCapotrasto = 1;
                    vp[i].pPosicion_capo = Convert.ToInt32(txtcapo.Text);
                    vp[i].pLetra1 = txtpartitura.Text;
                    vp[i].pLetra2 = txtpartitura2.Text;
                    vp[i].pId_genero = Convert.ToInt32(cbogenero.SelectedValue);
                    vp[i].pId_autor = Convert.ToInt32(cboautor.SelectedValue);
                    sql = "Update Partituras set nombre_cancion='" + vp[i].pNombre_cancion.Replace("'", "''") + "',capotrasto=" + vp[i].pCapotrasto + ",posicion_capo=" +
                        vp[i].pPosicion_capo + ",letra1='" + vp[i].pLetra1.Replace("'", "''") + "',letra2='"+ vp[i].pLetra2.Replace("'", "''") + "',id_genero=" + vp[i].pId_genero + ",id_autor=" + vp[i].pId_autor +
                        " where id_partitura=" + vp[i].pId_partitura;
                    
                        
                }
                datos.actualizarDB(sql);
                Habilitar(true);
                cargarLista("Partituras","order by 2");
                Limpiar();
                lstpartitura.Enabled = true;
                
            }
        }

        private void lstpartitura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = lstpartitura.SelectedIndex;
            txtpartitura.Text = vp[c].pLetra1;
            txtpartitura2.Text = vp[c].pLetra2;
            txtnombre.Text = vp[c].pNombre_cancion;
            txtcapo.Text = Convert.ToString(vp[c].pPosicion_capo);
            cboautor.SelectedValue = vp[c].pId_autor;
            cbogenero.SelectedValue = vp[c].pId_genero;
            if (vp[c].pCapotrasto == 0)
                rbtno.Checked = true;
            else
                if (vp[c].pCapotrasto == 1)
                rbtsi.Checked = true;

        }

        private void btmcancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(true);
            lstpartitura.Enabled = true;
        }

       

        private void txtcapo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btmeditar_Click(object sender, EventArgs e)
        {
            
            Habilitar(false);
            btmcancelar.Enabled = true;
            lstpartitura.Enabled = false;
        }

        private void btmborrar_Click(object sender, EventArgs e)
        {
            string sql = "";
            int c = lstpartitura.SelectedIndex;
            DialogResult rpta = MessageBox.Show("Esta seguro que desea eliminar " + vp[c].pNombre_cancion + " de la lista?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rpta == DialogResult.Yes)
            {
                sql = "Delete Partituras where id_partitura=" + vp[c].pId_partitura;
                datos.actualizarDB(sql);
            }
        }
    }
}
