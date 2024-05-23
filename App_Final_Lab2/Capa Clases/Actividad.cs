using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace App_Final_Lab2
{
    class Actividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion= "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= BD_Clientes.mdb";
        private String Tabla = "Actividad";

        private Int32 IdActividad;
        private String NombreAct;

        public Int32 idact { get { return IdActividad; }set { IdActividad = value; } }
        public String nomact { get { return NombreAct; } set { NombreAct = value; } }

        public void CargaActividad(ComboBox Combo) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idActividad";
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        
        }

        public string NombreActvidad(Int32 idactividad) 
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;

            OleDbDataReader DR = comando.ExecuteReader();
            String Nombre = "";
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    if (DR.GetInt32(0) == idactividad)
                    {
                        Nombre = DR.GetString(1);
                    }
                }
            }


            conexion.Close();
            return Nombre;
        }
    }
}
