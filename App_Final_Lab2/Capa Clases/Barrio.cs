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
    class Barrio
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= BD_Clientes.mdb";
        private String Tabla = "Barrio";

        private Int32 IdBarrio;
        private String NombreBarrio;

        public Int32 idbarrio { get { return IdBarrio; } set { IdBarrio = value; } }
        public String nombarrio { get { return NombreBarrio; } set { NombreBarrio = value; } }

        public void CargarBarrio(ComboBox Combo) 
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
                Combo.ValueMember = "idBarrio";
                
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        
        
        
        }

        public string BuscarNombreBarrio(Int32 idBarrio) 
        {

            try
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
                        if (DR.GetInt32(0) == idBarrio)
                        {
                            Nombre = DR.GetString(1);
                        }
                    }
                }


                conexion.Close();
                return Nombre;
            }
            catch (Exception)
            {

                throw;
            }
           
            


        }

    }
}
