using Sico.Dao;
using Sico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sico
{
    public partial class InformesEmpresaWF : Form
    {
        public InformesEmpresaWF()
        {
            InitializeComponent();
        }
        private void InformesEmpresaWF_Load(object sender, EventArgs e)
        {
            List<Reporte_Pagos> ListaPagosRecibidos = new List<Reporte_Pagos>();
            List<PlanHonorarios> ListaPlanes = new List<PlanHonorarios>();
            ////// Grafico Lista De Pagos Recibidos
            ListaPagosRecibidos = ReportesDao.ListarPagosRecibidos();
            if (ListaPagosRecibidos.Count > 0)
            {
                ValidarMes(ListaPagosRecibidos);
                DiseñoGrilla();
                dgvPagosRecibidos.Visible = true;
                foreach (var item in ListaPagosRecibidos)
                {
                    dgvPagosRecibidos.Rows.Add(item.anno, item.mes, item.MontoTotal);
                }
                dgvPagosRecibidos.AllowUserToAddRows = false;
                DiseñoGraficoProductosMasVendidos(ListaPagosRecibidos);
            }
            else
            { }
            ////// Grilla planes Vencimiento 
            ListaPlanes = ReportesDao.ListarPlanes();
            if (ListaPlanes.Count > 0)
            {
                DiseñoGrilla();
                dgvVencimientos.Visible = true;
                foreach (var item in ListaPlanes)
                {
                    dgvVencimientos.Rows.Add(item.NombreEmpresa, item.Descripcion, item.FechaHasta);
                }
                dgvVencimientos.AllowUserToAddRows = false;
            }
            else
            { }
            ////// Reportes Botones
            /// Total de Ventas
            List<Reporte_Pagos> listaPlanes = new List<Reporte_Pagos>();
            listaPlanes = ReportesDao.PlanesGenerados();
            lblTotalVentas.Text = Convert.ToString(listaPlanes[0].TotalPlanes);
            /// Caja de Ventas
            List<Reporte_Pagos> listaVentas3 = new List<Reporte_Pagos>();
            listaVentas3 = ReportesDao.CobroHonorarios();
            lblCajaVentas.Text = Convert.ToString(listaVentas3[0].CobroHonorarios);
            /// Total de Compras
            List<Reporte_Pagos> listaCompras = new List<Reporte_Pagos>();
            listaCompras = ReportesDao.PlanesAbiertos();
            lblTotalCompras.Text = Convert.ToString(listaCompras[0].TotalPlanesAbiertos);
            /// Pagos de Compras
            List<Reporte_Pagos> listaCompras2 = new List<Reporte_Pagos>();
            listaCompras2 = ReportesDao.PlanesCerrados();
            lblPagosProveedores.Text = Convert.ToString(listaCompras2[0].TotalPlanesCerrados);
        }

        private void ValidarMes(List<Reporte_Pagos> listaPagosRecibidos)
        {
            string Mes = "";
            foreach (var item in listaPagosRecibidos)
            {
                if (item.mes == "JANUARY")
                {
                    item.mes = "Enero";
                }
                if (item.mes == "FEBRUARY")
                {
                    item.mes = "Febrero";
                }
                if (item.mes == "MARCH")
                {
                    item.mes = "Marzo";
                }
                if (item.mes == "APRIL")
                {
                    item.mes = "Abril";
                }
                if (item.mes == "MAY")
                {
                    item.mes = "Mayo";
                }
                if (item.mes == "JUNE")
                {
                    item.mes = "Junio";
                }
                if (item.mes == "JULY")
                {
                    item.mes = "Julio";
                }
                if (item.mes == "AUGUST")
                {
                    item.mes = "Agosto";
                }
                if (item.mes == "SEPTEMBER")
                {
                    item.mes = "Septiembre";
                }
                if (item.mes == "OCTOBER")
                {
                    item.mes = "Octubre";
                }
                if (item.mes == "NOVEMBER")
                {
                    item.mes = "Noviembre";
                }
                if (item.mes == "DECEMBER")
                {
                    item.mes = "Diciembre";
                }
            }
        }

        private void DiseñoGrilla()
        {
            this.dgvPagosRecibidos.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvPagosRecibidos.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvPagosRecibidos.DefaultCellStyle.BackColor = Color.White;
            this.dgvPagosRecibidos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvPagosRecibidos.DefaultCellStyle.SelectionBackColor = Color.White;

            this.dgvVencimientos.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvVencimientos.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvVencimientos.DefaultCellStyle.BackColor = Color.White;
            this.dgvVencimientos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvVencimientos.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void DiseñoGraficoProductosMasVendidos(List<Reporte_Pagos> listaPagosRecibidos)
        {
            List<string> Nombre = new List<string>();
            List<string> Total = new List<string>();
            foreach (var item in listaPagosRecibidos)
            {
                Nombre.Add(item.anno + " " + item.mes);
                string total = Convert.ToString(item.MontoTotal);
                Total.Add(total);
            }
            chartPagosRecibidos.Series[0].Points.DataBindXY(Nombre, Total);
        }
        private void dgvPagosRecibidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagosRecibidos.CurrentCell.ColumnIndex == 3)
            {
                int anio = Convert.ToInt32(this.dgvPagosRecibidos.CurrentRow.Cells[0].Value.ToString());
                string mes = Convert.ToString(this.dgvPagosRecibidos.CurrentRow.Cells[1].Value.ToString());
                DetalleHonariosMensualesWF _detalle = new DetalleHonariosMensualesWF(anio, mes);
                _detalle.Show();
            }
        }
        private void dgvPagosRecibidos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPagosRecibidos.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dgvPagosRecibidos.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"grifo.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 25, e.CellBounds.Top + 0);
                this.dgvPagosRecibidos.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                this.dgvPagosRecibidos.Columns[e.ColumnIndex].Width = icoAtomico.Width + 45;
                e.Handled = true;
            }
        }
    }
}

