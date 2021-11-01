using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sico.Dao;
using Sico.Entidades;

namespace Sico.Negocio
{
    public class AgendaNeg
    {
        public static bool GuardarRecordatorio(Agenda agenda)
        {
            bool exito = false;
            try
            {
                ValidarCampos(agenda);
                exito = AgendaDao.GuardarRecordatorio(agenda);
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarCampos(Agenda agenda)
        {
            if (String.IsNullOrEmpty(agenda.Descripcion))
            {
                const string message = "El campo Recordatorio es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static bool EditarRecordatorio(Agenda agenda, int idAgendaSeleccionada)
        {
            bool exito = false;
            try { exito = AgendaDao.EditarRecordatorio(agenda, idAgendaSeleccionada); }
            catch (Exception ex)
            { }
            return exito;
        }
        public static List<Agenda> ListarRecordatoriosUsuario(int idUsuario)
        {
            List<Agenda> _listaAgenda = new List<Agenda>();
            try
            {
                _listaAgenda = AgendaDao.ListarRecordatoriosUsuario(idUsuario);
            }
            catch (Exception ex)
            {
            }
            return _listaAgenda;
        }

        public static bool AnularRecordatorio(int idRecordatorio)
        {
            bool exito = false;
            try
            {
                exito = AgendaDao.AnularRecordatorio(idRecordatorio);
            }
            catch (Exception ex)
            { }
            return exito;
        }
        public static List<Agenda> BuscarRecordatorio(int idAgendaSeleccionado)
        {
            List<Agenda> _listaAgenda = new List<Agenda>();
            try
            {
                _listaAgenda = AgendaDao.BuscarRecordatorio(idAgendaSeleccionado);
            }
            catch (Exception ex)
            {
            }
            return _listaAgenda;
        }
    }
}
