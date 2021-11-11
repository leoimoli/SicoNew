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
    public partial class IvaWF : Form
    {
        public IvaWF()
        {
            InitializeComponent();
        }
        private void IvaWF_Load(object sender, EventArgs e)
        {
            try
            {
                if (Sesion.UsuarioLogueado.idEmpresaSeleccionado == 0)
                {
                    List<FacturaCompra> _compras = new List<FacturaCompra>();
                    _compras = Dao.ComprasDao.BuscarUltimasFacturasIngresadas();
                    if (_compras.Count > 0)
                    {
                        DiseñoGrillaCompras();
                        lblMsjCompras.Visible = false;
                        lbl2.Visible = true;
                        dgvCompras.Visible = true;
                        foreach (var item in _compras)
                        {
                            dgvCompras.Rows.Add(item.NroFactura, item.Fecha, item.Monto, item.NombreCliente, item.NombreProveedor);
                        }
                    }
                    else
                    {
                        lbl2.Visible = false;
                        dgvCompras.Visible = false;
                        lblMsjCompras.Visible = true;
                        lblMsjCompras.Text = "No hay información de compras para Visualizar.";
                    }

                    List<SubCliente> _ventas = new List<SubCliente>();
                    _ventas = Dao.ClienteDao.BuscarUltimasFacturasVentasIngresadas();
                    if (_ventas.Count > 0)
                    {
                        DiseñoGrillaVentas();
                        lbl1.Visible = true;
                        lblMsjVentas.Visible = false;
                        dgvVentas.Visible = true;
                        foreach (var item in _ventas)
                        {
                            dgvVentas.Rows.Add(item.NroFactura, item.Fecha, item.Monto, item.NombreCliente, item.ApellidoNombre);
                        }
                    }
                    else
                    {
                        lbl1.Visible = false;
                        dgvVentas.Visible = false;
                        lblMsjVentas.Visible = true;
                        lblMsjVentas.Text = "No hay información de ventas para Visualizar.";
                    }
                }
                else
                {                  
                        List<FacturaCompra> _compras = new List<FacturaCompra>();
                        _compras = Dao.ComprasDao.BuscarUltimasFacturasComprasIngresadaPorEmpresa(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                        if (_compras.Count > 0)
                        {
                            DiseñoGrillaCompras();
                            lblMsjCompras.Visible = false;
                            lbl2.Visible = true;
                            dgvCompras.Visible = true;
                            foreach (var item in _compras)
                            {
                                dgvCompras.Rows.Add(item.NroFactura, item.Fecha, item.Monto, item.NombreCliente, item.NombreProveedor);
                            }
                        }
                        else
                        {
                            lbl2.Visible = false;
                            dgvCompras.Visible = false;
                            lblMsjCompras.Visible = true;
                            lblMsjCompras.Text = "No hay información de compras para Visualizar.";
                        }

                        List<SubCliente> _ventas = new List<SubCliente>();
                        _ventas = Dao.ClienteDao.BuscarUltimasFacturasVentasIngresadasPorEmpresa(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
                        if (_ventas.Count > 0)
                        {
                            DiseñoGrillaVentas();
                            lbl1.Visible = true;
                            lblMsjVentas.Visible = false;
                            dgvVentas.Visible = true;
                            foreach (var item in _ventas)
                            {
                                dgvVentas.Rows.Add(item.NroFactura, item.Fecha, item.Monto, item.NombreCliente, item.ApellidoNombre);
                            }
                        }
                        else
                        {
                            lbl1.Visible = false;
                            dgvVentas.Visible = false;
                            lblMsjVentas.Visible = true;
                            lblMsjVentas.Text = "No hay información de ventas para Visualizar.";
                        }

                    }
            }
            catch (Exception ex)
            { }
        }

        private void DiseñoGrillaVentas()
        {
            this.dgvVentas.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvVentas.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvVentas.DefaultCellStyle.BackColor = Color.White;
            this.dgvVentas.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvVentas.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void DiseñoGrillaCompras()
        {
            this.dgvCompras.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvCompras.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCompras.DefaultCellStyle.BackColor = Color.White;
            this.dgvCompras.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            this.dgvCompras.DefaultCellStyle.SelectionBackColor = Color.White;
        }
    }
}
