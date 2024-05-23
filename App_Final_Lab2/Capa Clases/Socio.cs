using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace App_Final_Lab2
{
    class Socio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= BD_Clientes.mdb" ;
        private String Tabla = "Socio";


        private Int32 IdSocio;
        private String Nombre;
        private String Direccion;
        private Int32 IdBarrio;
        private Int32 IdActividad;
        private Decimal Deuda;

        public int idsocio { get { return IdSocio; }  set { IdSocio = value; } }
        public string nom { get { return Nombre; }  set => Nombre = value; }
        public string dire { get { return Direccion; }  set { Direccion = value; }  }
        public int idbarrio { get { return IdBarrio; } set{ IdBarrio = value; }  }
        public int idact { get { return IdActividad; } set { IdActividad = value; }  }
        public decimal deu { get { return Deuda; } set { Deuda = value; }  }



        public void ListadoGeneral(DataGridView Grilla , Label Mayor , Label Menor , Label Promedio , Label Total) 
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

                Grilla.Rows.Clear();
                Int32 cantidad =0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;

                if (DS.Tables[Tabla].Rows.Count>0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Grilla.Rows.Add(fila["IdSocio"],fila["Nombre"],fila["Deuda"]);
                        deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                        cantidad++;
                        deuda = Convert.ToDecimal(fila["Deuda"]);
                        if (deuda > deudamayor | deuda == deudamayor)
                        {
                            deudamayor = deuda;
                        }
                     
                        if (deuda < deudamenor | deuda == deudamenor)
                        {
                            deudamenor = deuda;
                        }
                        
                    }
                }

                Promedio.Text = (deudatotal / cantidad).ToString("N2");
                Total.Text = deudatotal.ToString("N2");
                Mayor.Text = deudamayor.ToString();
                Menor.Text = deudamenor.ToString(); 

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
            
        
        
        
        
        
        
        }
        public void ListadoDeudores(DataGridView Grilla, Label Mayor, Label Menor, Label Promedio, Label Total)
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

                Grilla.Rows.Clear();
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                       
                        if (Convert.ToInt32(fila["Deuda"]) > 0)
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            cantidad++;

                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }

                        }
                       
                    }
                }

                Promedio.Text = (deudatotal / cantidad).ToString("N2");
                Total.Text = deudatotal.ToString("N2");
                Mayor.Text = deudamayor.ToString();
                Menor.Text = deudamenor.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }







        }

        public void ListadoActividad(DataGridView Grilla, Label Mayor, Label Menor, Label Promedio, Label Total,Int32 idActividad)
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

                Grilla.Rows.Clear();
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                       
                       
                        if (Convert.ToInt32(fila["idActividad"]) == idActividad)
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                           
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            cantidad++;
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            

                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }








                        }

                    }
                }

                Promedio.Text = (deudatotal / cantidad).ToString("N2");
                Total.Text = deudatotal.ToString("N2");
                Mayor.Text = deudamayor.ToString();
                Menor.Text = deudamenor.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }







        }
        public void ListadoBarrio(DataGridView Grilla, Label Mayor, Label Menor, Label Promedio, Label Total, Int32 idBarrio)
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

                Grilla.Rows.Clear();
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == idBarrio  )
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            cantidad++;
                            deuda = Convert.ToDecimal(fila["Deuda"]);

                            if (deudamayor < deuda )
                            {
                                deudamayor = deuda;
                            }
                           
                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }

                        }

                    }
                }

                Promedio.Text = (deudatotal / cantidad).ToString("N2");
                Total.Text = deudatotal.ToString("N2");
                Mayor.Text = deudamayor.ToString();
                Menor.Text = deudamenor.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }







        }

        public void AgregarSocio() 
        {
            try
            {
                String sql = "INSERT INTO Socio (IdSocio,Nombre,Direccion,idBarrio,idActividad,Deuda)";
                sql = sql + "Values (@idSocio,@Nombre,@Dire,@Barrio,@Actividad,@deu)";
                
                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Parameters.AddWithValue("@idSocio", idsocio);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Dire", dire);
                comando.Parameters.AddWithValue("@Barrio", idbarrio);
                comando.Parameters.AddWithValue("@Actividad", idact);
                comando.Parameters.AddWithValue("@deu", deu);

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }
            
        
        
        }
        public void BuscarSocio(Int32 idsocio ,  TextBox nombre , TextBox dire , ComboBox barrio , ComboBox Act , TextBox deuda,Button Modificar, Button Eliminar) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                
                String Nombrebarrio = "";
                String Nombreact = "";

                bool socioEncontrado = false; //

                if (DR.HasRows)
                {
                    Barrio b = new Barrio();
                    Actividad a = new Actividad();
                    while (DR.Read())
                    {
                        Nombrebarrio = b.BuscarNombreBarrio(DR.GetInt32(3));
                        Nombreact = a.NombreActvidad(DR.GetInt32(4));
                       
                        if (DR.GetInt32(0)== idsocio)
                        {
                            nombre.Text = DR.GetString(1);
                            dire.Text = DR.GetString(2);
                            barrio.Text = Nombrebarrio; 
                            Act.Text = Nombreact ;
                            deuda.Text = DR.GetDecimal(5).ToString();


                            Modificar.Visible = true;
                            Eliminar.Visible = true;
                            socioEncontrado = true;
                        }
                        
                       
                    }
                    if (socioEncontrado== false)
                    {
                        MessageBox.Show("Socio no encontrado por favor verifique el numero de identificacion y vuelva a intentar", "BUSCAR SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        nombre.Text = "";
                        dire.Text = "";
                        barrio.Text = "";
                        Act.Text = "";
                        deuda.Text = "";
                        Modificar.Visible = false;
                        Eliminar.Visible = false;
                    }
                    
                }
                
              


            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        
        
        
        
        
        }

        public void ModificarSocio()
        {
            try
            {
                String sql = "UPDATE Socio SET Nombre = @Nombre , Direccion = @Dire , idBarrio = @Barrio , idActividad = @Act , Deuda = @Deuda";
                sql = sql + " WHERE IdSocio = @IDSOCIO";

                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Dire", dire);
                comando.Parameters.AddWithValue("@Barrio", idbarrio);
                comando.Parameters.AddWithValue("@Act", idact);
                comando.Parameters.AddWithValue("@Deuda", deu);
                comando.Parameters.AddWithValue("@IDSOCIO", idsocio);


                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;



                comando.ExecuteNonQuery();



                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            




        }

        public void EliminarSocio(Int32 idso) 
        {

            try
            {
                String sql = "DELETE FROM Socio WHERE IdSocio = " + idso;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteReader();

            }
            catch (Exception e )
            {

                MessageBox.Show(e.ToString()); 
            }
            finally { conexion.Close(); }
        
        
        
        }

        public void CargaNombreSocio(ComboBox Combo) 
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
                Combo.ValueMember = "IdSocio";
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        
        }
        public void ConsultarSocio(Int32 idsoc, TextBox idSocio, TextBox dire, TextBox barrio, TextBox Act, TextBox deuda)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                String Nombrebarrio = "";
                String Nombreact = "";

               

                if (DR.HasRows)
                {
                    Barrio b = new Barrio();
                    Actividad a = new Actividad();
                    while (DR.Read())
                    {
                        Nombrebarrio = b.BuscarNombreBarrio(DR.GetInt32(3));
                        Nombreact = a.NombreActvidad(DR.GetInt32(4));

                        if (DR.GetInt32(0) == idsoc)
                        {
                            idSocio.Text = DR.GetInt32(0).ToString();
                            dire.Text = DR.GetString(2);
                            barrio.Text = Nombrebarrio;
                            Act.Text = Nombreact;
                            deuda.Text = DR.GetDecimal(5).ToString();


                           
                            
                        }


                    }
                    

                }




            }
            catch (Exception e )
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }





        }

        public void ImprimirReporteCompleto(String RutaArchivo) 
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

                adaptador.Fill(DS,Tabla);

                StreamWriter AD = new StreamWriter(RutaArchivo, false, Encoding.UTF8);

                //Titulo 
                AD.WriteLine("REPORTE GENERAL SOCIOS");
                AD.WriteLine("");

                // COLUMNAS 
                AD.Write("Id Socio");
                AD.Write(";");
                AD.Write("Nombre");
                AD.Write(";");
                AD.WriteLine("Deuda");

                // Variables 

                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        AD.Write(fila["IdSocio"]);
                        AD.Write(";");
                        AD.Write(fila["Nombre"]);
                        AD.Write(";");
                        AD.WriteLine(fila["Deuda"]);
                        cantidad++;
                        deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]) ;
                        deuda = Convert.ToDecimal(fila["Deuda"]);
                        if (deudamayor < deuda)
                        {
                            deudamayor = deuda;
                        }

                        if (Primerdeuda == 0 | Primerdeuda > deuda)
                        {
                            Primerdeuda = deuda;
                            deudamenor = deuda;
                        }
                        else
                        {
                            if (Primerdeuda != 0 && deudamenor > deuda)
                            {
                                deudamenor = deuda;
                            }
                        }
                    }
                }

                AD.WriteLine("");
                AD.Write("Mayor Deuda :;;");
                AD.WriteLine(deudamayor.ToString("N2"));
                AD.Write("Menor Deuda :;;");
                AD.WriteLine(deudamenor.ToString("N2"));
                AD.Write("Promedio Deuda :;;");
                AD.WriteLine((deudatotal/cantidad).ToString("N2"));
                AD.Write("Total Deuda :;;");
                AD.WriteLine(deudatotal);

                AD.Close();
                AD.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }
        
        
        
        
        
        }

        public void ImprimirReporteDeudores(String RutaArchivo)
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

                StreamWriter AD = new StreamWriter(RutaArchivo, false, Encoding.UTF8);

                //Titulo 
                AD.WriteLine("REPORTE GENERAL SOCIOS");
                AD.WriteLine("");

                // COLUMNAS 
                AD.Write("Id Socio");
                AD.Write(";");
                AD.Write("Nombre");
                AD.Write(";");
                AD.WriteLine("Deuda");

                // Variables 

                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["Deuda"]) > 0)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.Write(fila["Nombre"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Deuda"]);
                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }
                       
                    }
                }

                AD.WriteLine("");
                AD.Write("Mayor Deuda :;;");
                AD.WriteLine(deudamayor.ToString("N2"));
                AD.Write("Menor Deuda :;;");
                AD.WriteLine(deudamenor.ToString("N2"));
                AD.Write("Promedio Deuda :;;");
                AD.WriteLine((deudatotal / cantidad).ToString("N2"));
                AD.Write("Total Deuda :;;");
                AD.WriteLine(deudatotal);

                AD.Close();
                AD.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }





        }

        public void ImprimirReporteActividad(String RutaArchivo,Int32 idactividad)
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

                StreamWriter AD = new StreamWriter(RutaArchivo, false, Encoding.UTF8);

                //Titulo 
                AD.WriteLine("REPORTE GENERAL SOCIOS");
                AD.WriteLine("");

                // COLUMNAS 
                AD.Write("Id Socio");
                AD.Write(";");
                AD.Write("Nombre");
                AD.Write(";");
                AD.WriteLine("Deuda");

                // Variables 

                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == idactividad)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.Write(fila["Nombre"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Deuda"]);
                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }

                    }
                }

                AD.WriteLine("");
                AD.Write("Mayor Deuda :;;");
                AD.WriteLine(deudamayor.ToString("N2"));
                AD.Write("Menor Deuda :;;");
                AD.WriteLine(deudamenor.ToString("N2"));
                AD.Write("Promedio Deuda :;;");
                AD.WriteLine((deudatotal / cantidad).ToString("N2"));
                AD.Write("Total Deuda :;;");
                AD.WriteLine(deudatotal);

                AD.Close();
                AD.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }





        }

        public void ImprimirReporteBarrio(String RutaArchivo, Int32 idbarrio)
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

                StreamWriter AD = new StreamWriter(RutaArchivo, false, Encoding.UTF8);

                //Titulo 
                AD.WriteLine("REPORTE GENERAL SOCIOS");
                AD.WriteLine("");

                // COLUMNAS 
                AD.Write("Id Socio");
                AD.Write(";");
                AD.Write("Nombre");
                AD.Write(";");
                AD.WriteLine("Deuda");

                // Variables 

                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == idbarrio)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.Write(fila["Nombre"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Deuda"]);
                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }

                    }
                }

                AD.WriteLine("");
                AD.Write("Mayor Deuda :;;");
                AD.WriteLine(deudamayor.ToString("N2"));
                AD.Write("Menor Deuda :;;");
                AD.WriteLine(deudamenor.ToString("N2"));
                AD.Write("Promedio Deuda :;;");
                AD.WriteLine((deudatotal / cantidad).ToString("N2"));
                AD.Write("Total Deuda :;;");
                AD.WriteLine(deudatotal);

                AD.Close();
                AD.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }





        }

        public void CantidadSocios(Label CantidadSocios) 
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

                Int32 Cantidad = 0;
                if (DS.Tables[Tabla].Rows.Count>0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Cantidad++;
                    }
                }

                CantidadSocios.Text= Cantidad.ToString();

            }
            catch ( Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }
        
        
        
        
        
        }

        public void ImprimirListadoGeneral(PrintPageEventArgs Hoja) 
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


                Font LetraTitulo = new Font("Arial", 24);
                Font Letrasubtitulos = new Font("Arial", 18);
                Font Letra = new Font("Arial", 14);
                //Titulo 
                Hoja.Graphics.DrawString("REPORTE GENERAL SOCIOS",LetraTitulo, Brushes.Black,150,25);
               
                // primer numero indica movimiento lateral , segundo numero indica movimiento en altura
                // COLUMNAS 
                Hoja.Graphics.DrawString("Id Socio",Letrasubtitulos,Brushes.DarkGray,50,100);
                Hoja.Graphics.DrawString("Nombre", Letrasubtitulos, Brushes.DarkGray, 250, 100); 
                Hoja.Graphics.DrawString("Deuda", Letrasubtitulos, Brushes.DarkGray, 450, 100);



                // Variables 
                Int32 lineaimpresion = 150;
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Hoja.Graphics.DrawString(fila["IdSocio"].ToString(), Letra,Brushes.Blue,50, lineaimpresion);
                        Hoja.Graphics.DrawString(fila["Nombre"].ToString(), Letra, Brushes.Blue, 250, lineaimpresion);
                        Hoja.Graphics.DrawString(fila["Deuda"].ToString(), Letra, Brushes.Blue, 450, lineaimpresion);
                        lineaimpresion = lineaimpresion + 18;
                        
                        cantidad++;
                        deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                        deuda = Convert.ToDecimal(fila["Deuda"]);
                        if (deudamayor < deuda)
                        {
                            deudamayor = deuda;
                        }

                        if (Primerdeuda == 0 | Primerdeuda > deuda)
                        {
                            Primerdeuda = deuda;
                            deudamenor = deuda;
                        }
                        else
                        {
                            if (Primerdeuda != 0 && deudamenor > deuda)
                            {
                                deudamenor = deuda;
                            }
                        }
                    }
                }
                Decimal Promedio = deudatotal / cantidad ;
               
                Hoja.Graphics.DrawString("Mayor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion +20);
                Hoja.Graphics.DrawString(deudamayor.ToString(), Letrasubtitulos, Brushes.DarkGray,250, lineaimpresion +20);
                Hoja.Graphics.DrawString("Menor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 40);
                Hoja.Graphics.DrawString(deudamenor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 40);
                Hoja.Graphics.DrawString("Promedio:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 60);
                Hoja.Graphics.DrawString(Promedio.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 60); ;
                Hoja.Graphics.DrawString("Deuda Total:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 80);
                Hoja.Graphics.DrawString(deudatotal.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 80); ;


                




            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }
        
        
        
        
        
        
        
        
        }

        public void ImprimirListadoDeudores(PrintPageEventArgs Hoja)
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


                Font LetraTitulo = new Font("Arial", 24);
                Font Letrasubtitulos = new Font("Arial", 18);
                Font Letra = new Font("Arial", 14);
                //Titulo 
                Hoja.Graphics.DrawString("REPORTE SOCIOS DEUDORES", LetraTitulo, Brushes.Black, 150, 25);

                // primer numero indica movimiento lateral , segundo numero indica movimiento en altura
                // COLUMNAS 
                Hoja.Graphics.DrawString("Id Socio", Letrasubtitulos, Brushes.DarkGray, 50, 100);
                Hoja.Graphics.DrawString("Nombre", Letrasubtitulos, Brushes.DarkGray, 250, 100);
                Hoja.Graphics.DrawString("Deuda", Letrasubtitulos, Brushes.DarkGray, 450, 100);



                // Variables 
                Int32 lineaimpresion = 150;
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["Deuda"]) > 0)
                        {
                            Hoja.Graphics.DrawString(fila["IdSocio"].ToString(), Letra, Brushes.Blue, 50, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Nombre"].ToString(), Letra, Brushes.Blue, 250, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Deuda"].ToString(), Letra, Brushes.Blue, 450, lineaimpresion);
                            lineaimpresion = lineaimpresion + 18;

                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }
                       
                    }
                }
                Decimal Promedio = deudatotal / cantidad;

                Hoja.Graphics.DrawString("Mayor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 20);
                Hoja.Graphics.DrawString(deudamayor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 20);
                Hoja.Graphics.DrawString("Menor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 40);
                Hoja.Graphics.DrawString(deudamenor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 40);
                Hoja.Graphics.DrawString("Promedio:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 60);
                Hoja.Graphics.DrawString(Promedio.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 60); ;
                Hoja.Graphics.DrawString("Deuda Total:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 80);
                Hoja.Graphics.DrawString(deudatotal.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 80); ;







            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }








        }

        public void ImprimirListadoActividad(PrintPageEventArgs Hoja , ComboBox Combo,Int32 idActividad)
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


                Font LetraTitulo = new Font("Arial", 24);
                Font Letrasubtitulos = new Font("Arial", 18);
                Font Letra = new Font("Arial", 14);
                //Titulo 
                Hoja.Graphics.DrawString("REPORTE SOCIOS POR ACTIVIDAD", LetraTitulo, Brushes.Black, 150, 25);

                // primer numero indica movimiento lateral , segundo numero indica movimiento en altura
                // COLUMNAS 
                Hoja.Graphics.DrawString("Actividad: "+ Combo.Text, Letrasubtitulos, Brushes.DarkGray, 50, 100);
                Hoja.Graphics.DrawString("Id Socio", Letrasubtitulos, Brushes.DarkGray, 50, 150);
                Hoja.Graphics.DrawString("Nombre", Letrasubtitulos, Brushes.DarkGray, 250, 150);
                Hoja.Graphics.DrawString("Deuda", Letrasubtitulos, Brushes.DarkGray, 450, 150);



                // Variables 
                Int32 lineaimpresion = 200;
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {

                        if (Convert.ToInt32(fila["idActividad"]) == idActividad)
                        {
                            Hoja.Graphics.DrawString(fila["IdSocio"].ToString(), Letra, Brushes.Blue, 50, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Nombre"].ToString(), Letra, Brushes.Blue, 250, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Deuda"].ToString(), Letra, Brushes.Blue, 450, lineaimpresion);
                            lineaimpresion = lineaimpresion + 18;

                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }

                    }
                }
                Decimal Promedio = deudatotal / cantidad;

                Hoja.Graphics.DrawString("Mayor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 20);
                Hoja.Graphics.DrawString(deudamayor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 20);
                Hoja.Graphics.DrawString("Menor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 40);
                Hoja.Graphics.DrawString(deudamenor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 40);
                Hoja.Graphics.DrawString("Promedio:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 60);
                Hoja.Graphics.DrawString(Promedio.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 60); ;
                Hoja.Graphics.DrawString("Deuda Total:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 80);
                Hoja.Graphics.DrawString(deudatotal.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 80); ;







            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }








        }

        public void ImprimirListadoBarrio(PrintPageEventArgs Hoja, ComboBox Combo, Int32 idbarrio)
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


                Font LetraTitulo = new Font("Arial", 24);
                Font Letrasubtitulos = new Font("Arial", 18);
                Font Letra = new Font("Arial", 14);
                //Titulo 
                Hoja.Graphics.DrawString("REPORTE SOCIOS POR ACTIVIDAD", LetraTitulo, Brushes.Black, 150, 25);

                // primer numero indica movimiento lateral , segundo numero indica movimiento en altura
                // COLUMNAS 
                Hoja.Graphics.DrawString("Actividad: " + Combo.Text, Letrasubtitulos, Brushes.DarkGray, 50, 100);
                Hoja.Graphics.DrawString("Id Socio", Letrasubtitulos, Brushes.DarkGray, 50, 150);
                Hoja.Graphics.DrawString("Nombre", Letrasubtitulos, Brushes.DarkGray, 250, 150);
                Hoja.Graphics.DrawString("Deuda", Letrasubtitulos, Brushes.DarkGray, 450, 150);



                // Variables 
                Int32 lineaimpresion = 200;
                Int32 cantidad = 0;
                Decimal deudatotal = 0;
                Decimal deudamayor = 0;
                Decimal deudamenor = 0;
                Decimal deuda = 0;
                Decimal Primerdeuda = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {

                        if (Convert.ToInt32(fila["idBarrio"]) == idbarrio)
                        {
                            Hoja.Graphics.DrawString(fila["IdSocio"].ToString(), Letra, Brushes.Blue, 50, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Nombre"].ToString(), Letra, Brushes.Blue, 250, lineaimpresion);
                            Hoja.Graphics.DrawString(fila["Deuda"].ToString(), Letra, Brushes.Blue, 450, lineaimpresion);
                            lineaimpresion = lineaimpresion + 18;

                            cantidad++;
                            deudatotal = deudatotal + Convert.ToDecimal(fila["Deuda"]);
                            deuda = Convert.ToDecimal(fila["Deuda"]);
                            if (deudamayor < deuda)
                            {
                                deudamayor = deuda;
                            }

                            if (Primerdeuda == 0 | Primerdeuda > deuda)
                            {
                                Primerdeuda = deuda;
                                deudamenor = deuda;
                            }
                            else
                            {
                                if (Primerdeuda != 0 && deudamenor > deuda)
                                {
                                    deudamenor = deuda;
                                }
                            }
                        }

                    }
                }
                Decimal Promedio = deudatotal / cantidad;

                Hoja.Graphics.DrawString("Mayor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 20);
                Hoja.Graphics.DrawString(deudamayor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 20);
                Hoja.Graphics.DrawString("Menor Deuda:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 40);
                Hoja.Graphics.DrawString(deudamenor.ToString(), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 40);
                Hoja.Graphics.DrawString("Promedio:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 60);
                Hoja.Graphics.DrawString(Promedio.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 60); ;
                Hoja.Graphics.DrawString("Deuda Total:", Letrasubtitulos, Brushes.DarkGray, 50, lineaimpresion + 80);
                Hoja.Graphics.DrawString(deudatotal.ToString("N2"), Letrasubtitulos, Brushes.DarkGray, 250, lineaimpresion + 80); ;







            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally { conexion.Close(); }








        }

        
    }
}
