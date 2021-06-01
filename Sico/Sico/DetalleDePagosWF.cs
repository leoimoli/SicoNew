using Sico.Entidades;
using Sico.Negocio;
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
    public partial class DetalleDePagosWF : Form
    {
        public int idPlan;
        public double MontoTotal;
        public DetalleDePagosWF(int idPlan, double MontoTotal)
        {
            InitializeComponent();
            this.idPlan = idPlan;
            this.MontoTotal = MontoTotal;
        }
        private void DetalleDePagosWF_Load(object sender, EventArgs e)
        {
            BuscarHistoricoDePagos(idPlan, MontoTotal);
        }
        private void BuscarHistoricoDePagos(int idPlan, double montoTotal)
        {
            dgvHistorico.Rows.Clear();
            List<Entidades.PlanHonorarios> ListarClientes = HonorariosNeg.BuscarHistoricoDePagos(idPlan);
            if (ListarClientes.Count > 0)
            {
                DiseñoGrilla();
                dgvHistorico.Visible = true;
                double SaldoDeudor = MontoTotal;
                foreach (var item in ListarClientes)
                {
                    string Fecha = item.FechaDesde.ToShortDateString();
                    SaldoDeudor = SaldoDeudor - item.MontoPago;
                    dgvHistorico.Rows.Add(Fecha, item.MontoPago, SaldoDeudor, item.Observaciones);
                    ValidarDiseñoGrilla();
                }
                dgvHistorico.AllowUserToAddRows = false;
            }
        }
        private void ValidarDiseñoGrilla()
        {
            foreach (DataGridViewRow row in dgvHistorico.Rows)
            {
                double SaldoDeudor = 0;
                double Monto = 0;
                if (row.Cells[1].Value != null)
                {
                    Monto = Convert.ToDouble(row.Cells[1].Value);
                }
                if (row.Cells[2].Value != null)
                {
                    SaldoDeudor = Convert.ToDouble(row.Cells[2].Value);
                }
                //if (SaldoDeudor > Monto)
                //{
                //    row.DefaultCellStyle.ForeColor = Color.Red;
                //}
                //else { row.DefaultCellStyle.ForeColor = Color.Green; }
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvHistorico.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvHistorico.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvHistorico.DefaultCellStyle.BackColor = Color.White;
            this.dgvHistorico.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvHistorico.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PlanDeHonorariosWF planDeHonorarios = new PlanDeHonorariosWF();
            planDeHonorarios.BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlanDeHonorariosWF planDeHonorarios = new PlanDeHonorariosWF();
            planDeHonorarios.BuscarTodasLosPlanesParaElCliente(Sesion.UsuarioLogueado.idEmpresaSeleccionado);
            Hide();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            dgvHistorico.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvHistorico.MultiSelect = true;
            dgvHistorico.SelectAll();
            DataObject dataObj = dgvHistorico.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
