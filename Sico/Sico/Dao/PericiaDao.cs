using MySql.Data.MySqlClient;
using Sico.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Dao
{
    public class PericiaDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool ValidarPericiaExistente(string tribunal, string causa)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Pericias> lista = new List<Pericias>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Tribunal_in", tribunal),new MySqlParameter("Causa_in", causa) };
            string proceso = "ValidarPericiaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "pericia");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static bool InsertPericia(Pericias _pericia)
        {
            bool exito = false;
            if (_pericia.Archivo1 != "" || _pericia.Archivo2 != "" || _pericia.Archivo3 != "")
            {
                exito = GuardarImagenesEnCarpeta(_pericia);
            }
            connection.Close();
            connection.Open();
            string proceso = "AltaPericia";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Tribunal_in", _pericia.Tribunal);
            cmd.Parameters.AddWithValue("Fecha_in", _pericia.Fecha);
            cmd.Parameters.AddWithValue("NroCausa_in", _pericia.NroCausa);
            cmd.Parameters.AddWithValue("Causa_in", _pericia.Causa);
            cmd.Parameters.AddWithValue("Archivo1_in", _pericia.Archivo1);
            cmd.Parameters.AddWithValue("Archivo2_in", _pericia.Archivo2);
            cmd.Parameters.AddWithValue("Archivo3_in", _pericia.Archivo3);
            cmd.Parameters.AddWithValue("Compartido_in", _pericia.Compartido);
            cmd.Parameters.AddWithValue("Email_in", _pericia.Email);
            cmd.Parameters.AddWithValue("Estado_in", _pericia.Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        private static bool GuardarImagenesEnCarpeta(Pericias _pericia)
        {
            bool exito = false;
            if (_pericia.Archivo1 != "")
            {
                string NombreArchivo = System.IO.Path.GetFileName(_pericia.Archivo1);
                string sourcePath = System.IO.Path.GetDirectoryName(_pericia.Archivo1);
                string targetPath = @"C:\Users\Public\TestFolder\SubDir";
                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath);
                string destFile = System.IO.Path.Combine(targetPath, NombreArchivo);

                // To copy a folder's contents to a new location:
                // Create a new target folder, if necessary.
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                // To copy a file to another location and 
                // overwrite the destination file if it already exists.
                // System.IO.File.Copy(sourceFile, destFile, true);

                // To copy all the files in one directory to another directory.
                // Get the files in the source folder. (To recursively iterate through
                // all subfolders under the current directory, see
                // "How to: Iterate Through a Directory Tree.")
                // Note: Check for target path was performed previously
                //       in this code example.
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        string fileName = System.IO.Path.GetFileName(s);
                        if (fileName == NombreArchivo)
                        {
                            destFile = System.IO.Path.Combine(targetPath, fileName);
                            System.IO.File.Copy(s, destFile, true);
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    // MessageBox.Show("Error");
                }
            }
            return exito;
        }
    }
}
