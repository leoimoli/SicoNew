using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sico.Entidades;
using System.Windows.Forms;
using Sico.Dao;

namespace Sico.Negocio
{
    public class PericiaNeg
    {
        public static bool GurdarPericia(Pericias _pericia)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_pericia);
                bool PericiaExistente = ValidarPericiaExistente(_pericia.Tribunal, _pericia.Causa);

                if (PericiaExistente == true)
                {
                    const string message = "Ya existe una pericia registrada con el mismo nombre de causa y tribunal asociado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    _pericia.Estado = "Iniciada";
                    exito = PericiaDao.InsertPericia(_pericia);
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static bool ValidarPericiaExistente(string tribunal, string causa)
        {
            bool existe = PericiaDao.ValidarPericiaExistente(tribunal, causa);
            return existe;
        }
        private static void ValidarDatos(Pericias _pericia)
        {
            if (String.IsNullOrEmpty(_pericia.Tribunal) || _pericia.Tribunal == "Seleccione")
            {
                const string message = "El campo Tribunal es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_pericia.NroCausa))
            {
                const string message = "El campo Nro.Causa es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_pericia.Causa))
            {
                const string message = "El campo Causa es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (_pericia.Compartido == 1)
            {
                if (String.IsNullOrEmpty(_pericia.Email))
                {
                    const string message = "El campo Email es obligatorio.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
            }

        }
    }
}
