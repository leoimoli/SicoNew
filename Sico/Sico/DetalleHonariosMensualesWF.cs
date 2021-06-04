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
    public partial class DetalleHonariosMensualesWF : Form
    {
        private int anio;
        private string mes;
        public DetalleHonariosMensualesWF(int anio, string mes)
        {
            InitializeComponent();
            this.anio = anio;
            this.mes = mes;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            dgvDetalleMensual.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvDetalleMensual.MultiSelect = true;
            dgvDetalleMensual.SelectAll();
            DataObject dataObj = dgvDetalleMensual.GetClipboardContent();
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
        private void DetalleHonariosMensualesWF_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarDetalleMensualDePagosHonorarios(anio, mes);
            }
            catch (Exception ex)
            { }
        }
        private void BuscarDetalleMensualDePagosHonorarios(int anio, string mes)
        {
            dgvDetalleMensual.Rows.Clear();
            List<Entidades.PlanHonorarios> ListarClientes = HonorariosNeg.BuscarDetalleMensualDePagosHonorarios(anio, mes);
            if (ListarClientes.Count > 0)
            {
                DiseñoGrilla();
                dgvDetalleMensual.Visible = true;
                foreach (var item in ListarClientes)
                {
                  dgvDetalleMensual.Rows.Add(item.NombreEmpresa, item.FechaPago, item.MontoTotal, item.Observaciones);
                }
                dgvDetalleMensual.AllowUserToAddRows = false;
            }
        }
        private void DiseñoGrilla()
        {
            this.dgvDetalleMensual.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dgvDetalleMensual.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvDetalleMensual.DefaultCellStyle.BackColor = Color.White;
            this.dgvDetalleMensual.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvDetalleMensual.DefaultCellStyle.SelectionBackColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
