using MySql.Data.MySqlClient;
using Sico.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            bool exitoGuardarImagenes = false;
            if (_pericia.Archivo1 != "" || _pericia.Archivo2 != "" || _pericia.Archivo3 != "")
            {
                exitoGuardarImagenes = GuardarImagenesEnCarpeta(_pericia);
            }
            if (exitoGuardarImagenes == true)
            {
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
                if (exito == true & _pericia.Compartido == 1)
                { bool EmailConExito = EnviarEmail(_pericia); }

            }
            return exito;
        }

        private static bool EnviarEmail(Pericias _pericia)
        {
            bool exito = false;
            string emisor = "leoimoli@gmail.com";
            string pwd = "Leo33244793";
            string correo = "Estimada/o, le informamos se recibio una nueva pericia con Número de causa " + _pericia.NroCausa + " y referente a la causa " + _pericia.Causa + "  abierta en el tribunal " + _pericia.Tribunal + " con fecha de creación " + _pericia.Fecha + " sin mas, les dejo mi saludo. Romina Arbizu.";
            string adjunto1 = Adj1;
            string adjunto2 = Adj2;
            string adjunto3 = Adj3;
            string archivoAdjunto = adjunto1 + adjunto2 + adjunto3;
            MailMessage msg = new MailMessage();
            //Quien escribe al correo
            msg.From = new MailAddress(emisor);
            //A quien va dirigido
            msg.To.Add(new MailAddress(_pericia.Email));
            //Asunto
            msg.Subject = _pericia.NroCausa + _pericia.Causa;
            //Contenido del correo
            msg.Body = correo;
            //Adjuntamos archivo
            if (adjunto1 != "")
                msg.Attachments.Add(new Attachment(archivoAdjunto, System.Net.Mime.MediaTypeNames.Application.Pdf));
            //Servidor smtp de hotmail
            //SmtpClient clienteSmtp = new SmtpClient();
            //clienteSmtp.Host = "smtp.live.com";
            //clienteSmtp.Port = 25;
            //clienteSmtp.EnableSsl = true;
            //clienteSmtp.UseDefaultCredentials = true;
            //var client = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential(emisor, pwd),
            //    EnableSsl = true
            //};

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 2525;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emisor, pwd);

            //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            //System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient();
            //SmtpServer.Credentials = new System.Net.NetworkCredential(emisor, pwd);
            //SmtpServer.Port = 587;
            //SmtpServer.Host = "smtp.gmail.com";
            //SmtpServer.EnableSsl = true;
            //SmtpServer.UseDefaultCredentials = true;
            //Se envia el correo
            //clienteSmtp.Credentials = new NetworkCredential(emisor, pwd);
            //clienteSmtp.EnableSsl = true;
            try
            {
                smtp.Send(msg);
                exito = true;
                //MessageBox.Show("Correo enviado");
            }
            catch (Exception ex)
            {

            }            return exito;
        }
        public static string Adj1;
        public static string Adj2;
        public static string Adj3;
        private static bool GuardarImagenesEnCarpeta(Pericias _pericia)
        {
            bool exito = false;
            bool exito1 = false;
            bool exito2 = false;
            bool exito3 = false;
            if (_pericia.Archivo1 != "")
            {
                string NombreArchivo = System.IO.Path.GetFileName(_pericia.Archivo1);
                string sourcePath = System.IO.Path.GetDirectoryName(_pericia.Archivo1);
                Adj1 = _pericia.Archivo1;
                string targetPath = @"C:\Sico\Archivos";
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
                            _pericia.Archivo1 = destFile;
                            exito1 = true;
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
            if (_pericia.Archivo2 != "")
            {
                exito2 = false;
                string NombreArchivo = System.IO.Path.GetFileName(_pericia.Archivo2);
                string sourcePath = System.IO.Path.GetDirectoryName(_pericia.Archivo2);
                Adj2 = _pericia.Archivo2;
                string targetPath = @"C:\Sico\Archivos";
                string sourceFile = System.IO.Path.Combine(sourcePath);
                string destFile = System.IO.Path.Combine(targetPath, NombreArchivo);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);
                    foreach (string s in files)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        if (fileName == NombreArchivo)
                        {
                            destFile = System.IO.Path.Combine(targetPath, fileName);
                            System.IO.File.Copy(s, destFile, true);
                            _pericia.Archivo2 = destFile;
                            exito2 = true;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                }
            }

            if (_pericia.Archivo3 != "")
            {
                exito3 = false;
                string NombreArchivo = System.IO.Path.GetFileName(_pericia.Archivo3);
                string sourcePath = System.IO.Path.GetDirectoryName(_pericia.Archivo3);
                Adj3 = _pericia.Archivo3;
                string targetPath = @"C:\Sico\Archivos";
                string sourceFile = System.IO.Path.Combine(sourcePath);
                string destFile = System.IO.Path.Combine(targetPath, NombreArchivo);
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);
                    foreach (string s in files)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        if (fileName == NombreArchivo)
                        {
                            destFile = System.IO.Path.Combine(targetPath, fileName);
                            System.IO.File.Copy(s, destFile, true);
                            _pericia.Archivo3 = destFile;
                            exito3 = true;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {

                }
            }
            if (exito1 == true || exito2 == true || exito3 == true)
                exito = true;
            return exito;
        }
    }
}




