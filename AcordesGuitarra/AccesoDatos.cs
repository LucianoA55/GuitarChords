using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace AcordesGuitarra
{
    class AccesoDatos
    {
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataReader lector;
        private DataTable tabla;
        private string cadenaConexion;

        public OleDbDataReader pLector { get => lector; set => lector = value; }
        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

        public AccesoDatos()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
            lector = null;
            cadenaConexion = @"Provider=SQLNCLI11;Data Source=Luciano-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AcordesGuitarra";
        }
        public AccesoDatos(string cadenaConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
            lector = null;
            this.cadenaConexion = cadenaConexion;
        }
        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            comando.Connection = conexion;
            conexion.Open();
            comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            conexion.Close();
        }
        public void LeerTabla(string nombreTabla,string condicion)
        {
            conectar();
            comando.CommandText = "Select * from " + nombreTabla+" "+condicion;
            lector = comando.ExecuteReader();
        }
        public void LeerTabla2(string sql)
        {
            conectar();
            comando.CommandText = sql;
            lector = comando.ExecuteReader();
        }
        public DataTable ConsultarTabla(string nombreTabla,string condicion)
        {
            conectar();
            comando.CommandText = "Select * from " + nombreTabla+" "+condicion;
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable ConsultarDB(string sql)
        {
            conectar();
            comando.CommandText = sql;
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public void actualizarDB(string sql)
        {
            conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            desconectar();
        }

    }
}
