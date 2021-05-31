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
    public class HonorariosNeg
    {
        public static bool EditarPlan(PlanHonorarios plan)
        {
            bool exito = false;
            try
            {
                ValidarDatos(plan);
                exito = HonorariosDao.EditarPlan(plan);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatos(PlanHonorarios plan)
        {
            if (String.IsNullOrEmpty(plan.Descripcion))
            {
                const string message = "El campo Descripción es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (plan.FechaDesde > plan.FechaHasta)
            {
                const string message = "La fecha desde no puede ser menor a fecha hasta.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (plan.MontoMensual == 0)
            {
                const string message = "El campo Monto Mensual es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static List<PlanHonorarios> BuscarHistoricoDePagos(int idPlan)
        {
            List<PlanHonorarios> _listaHistorico = new List<PlanHonorarios>();
            try
            {
                _listaHistorico = HonorariosDao.BuscarHistoricoDePagos(idPlan);
            }
            catch (Exception ex)
            {

            }
            return _listaHistorico;
        }
        public static bool RegistroPago(PlanHonorarios plan)
        {
            bool exito = false;
            try
            {
                ValidarDatosPago(plan);
                exito = HonorariosDao.RegistrarPago(plan);
                if (exito == true)
                {
                    List<PlanHonorarios> _listaPagos = new List<PlanHonorarios>();
                    _listaPagos = HonorariosDao.ListarPagosDelPlan(plan.idPlan);
                    if (_listaPagos.Count > 0)
                    {
                        double SumaPagos = 0;
                        foreach (var item in _listaPagos)
                        {
                            double valor = item.MontoPago;
                            SumaPagos = valor + SumaPagos;
                        }
                        if (SumaPagos == plan.MontoTotal)
                        {
                            exito = HonorariosDao.CierroEstadoPlan(plan.idPlan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatosPago(PlanHonorarios plan)
        {
            if (plan.MontoPago == 0 || plan.MontoPago == null)
            {
                const string message = "El campo Monto es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static bool GurdarPlan(PlanHonorarios plan)
        {
            bool exito = false;
            try
            {
                ValidarDatos(plan);
                exito = HonorariosDao.GurdarPlan(plan);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        public static List<PlanHonorarios> ListarTodosPlanesParaCliente(int idEmpresaSeleccionado)
        {
            List<PlanHonorarios> _listaPlanes = new List<PlanHonorarios>();
            try
            {
                _listaPlanes = HonorariosDao.ListarTodosPlanesParaCliente(idEmpresaSeleccionado);
            }
            catch (Exception ex)
            {

            }
            return _listaPlanes;
        }
    }
}
