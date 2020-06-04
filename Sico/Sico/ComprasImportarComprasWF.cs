using Sico.Clases_Maestras;
using Sico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sico.Entidades;

namespace Sico
{
    public partial class ComprasImportarComprasWF : Form
    {
        private string cuit;
        private string razonSocial;
        public ComprasImportarComprasWF(string razonSocial, string cuit)
        {
            InitializeComponent();
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            RazonSocial = razonSocial;
            Cuit = cuit;
        }
        public static string RazonSocial;
        public static string Cuit;
        private void ComprasImportarComprasWF_Load(object sender, EventArgs e)
        {
            try
            {
                lblCuitEdit.Text = cuit;
                lblNombreEdit.Text = razonSocial;
                CargarCombo();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void CargarCombo()
        {
            List<string> Periodo = new List<string>();
            Periodo = PeriodoNeg.CargarComboPeriodoCompras(cuit);
            cmbPeriodo.Items.Clear();
            foreach (string item in Periodo)
            {

                cmbPeriodo.Items.Add(item);
            }
        }
        public void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            btnVolver.Enabled = true;
        }
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtRuta.Text = path;
                sr.Close();
            }
        }
        private void btnCrearPeriodo_Click(object sender, EventArgs e)
        {
            PeriodosWF _periodo = new PeriodosWF(cuit, razonSocial);
            _periodo.Show();
        }
        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ComprasWF _compras = new ComprasWF(razonSocial, cuit);
            _compras.Show();
            Hide();
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            ProgressBar();
            btnCargarDatos.Enabled = false;
            Datos();
            btnCargaMasiva.Enabled = true;
            LimpiarCampos();
        }
        private void Datos()
        {
            string RutaCargada = txtRuta.Text;
            //Hoja desde donde obtendremos los datos
            string hoja = "Sheet1";
            //Cadena de conexión
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                           RutaCargada +
                            ";Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(conexion);
            //Consulta contra la hoja de Excel
            OleDbCommand cmd = new OleDbCommand("Select * From [" + hoja + "$]", con);
            //Conectarse al archivo de Excel
            con.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable data = new DataTable();
            //Cargar los datos
            sda.Fill(data);
            List<Entidades.FacturaCompra> listaSubCliente = new List<Entidades.FacturaCompra>();
            try
            {
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        string VARImpNetoGravado = "";
                        string VARImpNetoNoGravado = "";
                        string VARImpOpExentas = "";

                        double ImpNetoGravado;
                        double ImpNetoNoGravado;
                        double ImpOpExentas;
                        decimal Iva;
                        Entidades.FacturaCompra list = new Entidades.FacturaCompra();
                        list.Fecha = item[0].ToString();
                        if (list.Fecha == "Fecha")
                        { continue; }
                        list.TipoComprobante = item[1].ToString();
                        if (list.TipoComprobante == "6 - Factura B" || list.TipoComprobante == "1 - Factura A")
                        {
                            list.NroFactura = item[2].ToString() + "|" + item[3].ToString();
                        }
                        if (list.TipoComprobante == "8 - Nota de Crédito B" || list.TipoComprobante == "13 - Nota de Crédito C")
                        {
                            list.NroFacturaNotaDeCredtio = item[2].ToString() + "|" + item[3].ToString();
                        }
                        if (list.TipoComprobante == "11 - Factura C")
                        {
                            list.NroFactura = item[2].ToString() + "|" + item[3].ToString();
                        }
                        if (list.TipoComprobante == "13 - Nota de Crédito C")
                        {
                            list.NroFacturaNotaDeCredtio = item[2].ToString() + "|" + item[3].ToString();
                        }
                        list.CodigoDocumento = item[6].ToString();
                        if (list.CodigoDocumento == "CUIT")
                        {
                            list.CodigoDocumento = "80";
                        }
                        if (list.CodigoDocumento == "DNI")
                        {
                            list.CodigoDocumento = "96";
                        }
                        list.Cuit = item[7].ToString();
                        list.NombreProveedor = item[8].ToString();
                        list.TipoDeCambio = item[9].ToString();
                        list.CodigoMoneda = item[10].ToString();
                        if (list.CodigoMoneda == "$")
                        {
                            list.CodigoMoneda = "PES - PesosArgentinos";
                        }

                        if (item[11].ToString() != "")
                        {
                            double varImpNetoGravado = Convert.ToDouble(item[11].ToString());
                            VARImpNetoGravado = string.Format("{0:n2}", (Math.Truncate(varImpNetoGravado * 100) / 100));
                            ImpNetoGravado = Math.Round(Convert.ToDouble(VARImpNetoGravado), 2);
                        }
                        else { VARImpNetoGravado = "0"; ImpNetoGravado = 0; }

                        if (item[12].ToString() != "")
                        {
                            double varImpNetoNoGravado = Convert.ToDouble(item[12].ToString());
                            VARImpNetoNoGravado = string.Format("{0:n2}", (Math.Truncate(varImpNetoNoGravado * 100) / 100));
                            ImpNetoNoGravado = Convert.ToDouble(VARImpNetoNoGravado);
                        }
                        else { VARImpNetoNoGravado = "0"; ImpNetoNoGravado = 0; }

                        if (item[13].ToString() != "")
                        {
                            double varImpOpExentas = Convert.ToDouble(item[13].ToString());
                            VARImpOpExentas = string.Format("{0:n2}", (Math.Truncate(varImpOpExentas * 100) / 100));
                            ImpOpExentas = Convert.ToDouble(VARImpOpExentas);
                        }
                        else { VARImpOpExentas = "0"; ImpOpExentas = 0; }

                        if (item[14].ToString() != "")
                        {
                            double varIVA = Convert.ToDouble(item[14].ToString());
                            string IVA = string.Format("{0:n2}", (Math.Truncate(varIVA * 100) / 100));
                            Iva = Convert.ToDecimal(IVA);
                        }
                        else { Iva = 0; }

                        if (item[15].ToString() != "")
                        {
                            double varMon = Convert.ToDouble(item[15].ToString());
                            string Mont = string.Format("{0:n2}", (Math.Truncate(varMon * 100) / 100));
                            list.Monto = Convert.ToDecimal(Mont);
                        }
                        else { list.Monto = 0; }
                        if (ImpNetoGravado > 0)
                        {
                            ///// Calculo al %10,5
                            string Valor1 = Convert.ToString(Math.Round((ImpNetoGravado * 0.105), 2));
                            decimal resultado1 = Convert.ToDecimal(Valor1);
                            if (resultado1 == Iva)
                            {
                                list.Total1 = Convert.ToDecimal(list.Monto);
                                list.Iva1 = Convert.ToDecimal(Iva);
                                list.Neto1 = Convert.ToDecimal(ImpNetoGravado);
                            }
                            ///// Calculo al %21
                            string Valor2 = Convert.ToString(Math.Round((ImpNetoGravado * 0.21), 2));
                            decimal resultado2 = Convert.ToDecimal(Valor2);
                            if (resultado2 == Iva)
                            {
                                list.Total2 = Convert.ToDecimal(list.Monto);
                                list.Iva2 = Convert.ToDecimal(Iva);
                                list.Neto2 = Convert.ToDecimal(ImpNetoGravado);
                            }
                            ///// Calculo al %27
                            string Valor3 = Convert.ToString(Math.Round((ImpNetoGravado * 0.27), 2));
                            decimal resultado3 = Convert.ToDecimal(Valor3);
                            if (resultado3 == Iva)
                            {
                                list.Total3 = Convert.ToDecimal(list.Monto);
                                list.Iva3 = Convert.ToDecimal(Iva);
                                list.Neto3 = Convert.ToDecimal(ImpNetoGravado);
                            }

                            else
                            {
                                ///// Calculo al %10,5
                                var trncateCalculo1 = ImpNetoGravado * 0.105;
                                trncateCalculo1 = Math.Truncate(trncateCalculo1 * 100) / 100;
                                decimal TruncateResultado1 = Convert.ToDecimal(trncateCalculo1);
                                if (TruncateResultado1 == Iva)
                                {
                                    list.Total1 = Convert.ToDecimal(list.Monto);
                                    list.Iva1 = Convert.ToDecimal(Iva);
                                    list.Neto1 = Convert.ToDecimal(ImpNetoGravado);
                                }
                                ///// Calculo al %21
                                var trncateCalculo2 = ImpNetoGravado * 0.21;
                                trncateCalculo2 = Math.Truncate(trncateCalculo2 * 100) / 100;
                                decimal TruncateResultado2 = Convert.ToDecimal(trncateCalculo2);
                                if (TruncateResultado2 == Iva)
                                {
                                    list.Total2 = Convert.ToDecimal(list.Monto);
                                    list.Iva2 = Convert.ToDecimal(Iva);
                                    list.Neto2 = Convert.ToDecimal(ImpNetoGravado);
                                }
                                ///// Calculo al %27
                                var trncateCalculo3 = ImpNetoGravado * 0.27;
                                trncateCalculo3 = Math.Truncate(trncateCalculo3);
                                decimal TruncateResultado3 = Convert.ToDecimal(trncateCalculo3);
                                if (TruncateResultado3 == Iva)
                                {
                                    list.Total3 = Convert.ToDecimal(list.Monto);
                                    list.Iva3 = Convert.ToDecimal(Iva);
                                    list.Neto3 = Convert.ToDecimal(ImpNetoGravado);
                                }
                            }
                        }
                        ////// Agrego Percepcionj Iva e Ingresos Brutos
                        list.PercepIva = 0;
                        list.PercepIngBrutos = 0;
                        dataGridView1.Visible = true;
                        listaSubCliente.Add(list);
                        var contadortotal = listaSubCliente.Count;
                        label4.Visible = true;
                        label5.Visible = true;
                        label4.Text = Convert.ToString(contadortotal);
                        //ListaPrecargada = listaSubCliente;
                        dataGridView1.Rows.Add(list.Fecha, list.TipoComprobante, list.NroFactura, list.TipoComprobante, list.Cuit, list.NombreProveedor, list.TipoDeCambio, list.CodigoMoneda, VARImpNetoGravado, VARImpNetoNoGravado, VARImpOpExentas, list.PercepIva, list.PercepIngBrutos, Iva, list.Monto);
                    }
                    ListaStatic = listaSubCliente;
                    ValidarDiseñoGrilla();
                    btnCargaMasiva.Visible = true;
                    Calculos(listaSubCliente);
                }
            }
            catch (Exception ex)
            { }
        }
        public static List<Entidades.FacturaCompra> ListaStatic;
        private void Calculos(List<FacturaCompra> listaSubCliente)
        {
            DataTable data = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(FacturaCompra));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (FacturaCompra item in listaSubCliente)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            //foreach (var item in listaSubCliente)
            //{
            //    data.Rows.Add(item);
            //}
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    string VARImpNetoGravado = "";
                    string VARImpNetoNoGravado = "";
                    string VARImpOpExentas = "";

                    double ImpNetoGravado;
                    double ImpNetoNoGravado;
                    double ImpOpExentas;
                    decimal Iva;
                    Entidades.FacturaCompra list = new Entidades.FacturaCompra();
                    list.Fecha = item[0].ToString();
                    if (list.Fecha == "Fecha")
                    { continue; }
                    list.TipoComprobante = item[1].ToString();
                    if (list.TipoComprobante == "6 - Factura B" || list.TipoComprobante == "1 - Factura A")
                    {
                        list.NroFactura = item[2].ToString() + "|" + item[3].ToString();
                    }
                    if (list.TipoComprobante == "8 - Nota de Crédito B" || list.TipoComprobante == "003 - Nota de Crédito A")
                    {
                        list.NroFacturaNotaDeCredtio = item[2].ToString() + "|" + item[3].ToString();
                    }
                    if (list.TipoComprobante == "11 - Factura C")
                    {
                        list.NroFactura = item[2].ToString() + "|" + item[3].ToString();
                    }
                    if (list.TipoComprobante == "13 - Nota de Crédito C")
                    {
                        list.NroFacturaNotaDeCredtio = item[2].ToString() + "|" + item[3].ToString();
                    }
                    list.CodigoDocumento = item[6].ToString();
                    if (list.CodigoDocumento == "CUIT")
                    {
                        list.CodigoDocumento = "80";
                    }
                    if (list.CodigoDocumento == "DNI")
                    {
                        list.CodigoDocumento = "96";
                    }
                    list.Cuit = item[7].ToString();
                    list.NombreProveedor = item[8].ToString();
                    list.TipoDeCambio = item[9].ToString();
                    list.CodigoMoneda = item[10].ToString();
                    if (list.CodigoMoneda == "$")
                    {
                        list.CodigoMoneda = "PES - PesosArgentinos";
                    }

                    if (item[11].ToString() != "")
                    {
                        double varImpNetoGravado = Convert.ToDouble(item[11].ToString());
                        VARImpNetoGravado = string.Format("{0:n2}", (Math.Truncate(varImpNetoGravado * 100) / 100));
                        ImpNetoGravado = Math.Round(Convert.ToDouble(VARImpNetoGravado), 2);
                    }
                    else { VARImpNetoGravado = "0"; ImpNetoGravado = 0; }

                    if (item[12].ToString() != "")
                    {
                        double varImpNetoNoGravado = Convert.ToDouble(item[12].ToString());
                        VARImpNetoNoGravado = string.Format("{0:n2}", (Math.Truncate(varImpNetoNoGravado * 100) / 100));
                        ImpNetoNoGravado = Convert.ToDouble(VARImpNetoNoGravado);
                    }
                    else { VARImpNetoNoGravado = "0"; ImpNetoNoGravado = 0; }

                    if (item[13].ToString() != "")
                    {
                        double varImpOpExentas = Convert.ToDouble(item[13].ToString());
                        VARImpOpExentas = string.Format("{0:n2}", (Math.Truncate(varImpOpExentas * 100) / 100));
                        ImpOpExentas = Convert.ToDouble(VARImpOpExentas);
                    }
                    else { VARImpOpExentas = "0"; ImpOpExentas = 0; }

                    if (item[14].ToString() != "")
                    {
                        double varIVA = Convert.ToDouble(item[14].ToString());
                        string IVA = string.Format("{0:n2}", (Math.Truncate(varIVA * 100) / 100));
                        Iva = Convert.ToDecimal(IVA);
                    }
                    else { Iva = 0; }

                    if (item[15].ToString() != "")
                    {
                        double varMon = Convert.ToDouble(item[15].ToString());
                        string Mont = string.Format("{0:n2}", (Math.Truncate(varMon * 100) / 100));
                        list.Monto = Convert.ToDecimal(Mont);
                    }
                    else { list.Monto = 0; }
                    if (ImpNetoGravado > 0)
                    {
                        ///// Calculo al %10,5
                        string Valor1 = Convert.ToString(Math.Round((ImpNetoGravado * 0.105), 2));
                        decimal resultado1 = Convert.ToDecimal(Valor1);
                        if (resultado1 == Iva)
                        {
                            list.Total1 = Convert.ToDecimal(list.Monto);
                            list.Iva1 = Convert.ToDecimal(Iva);
                            list.Neto1 = Convert.ToDecimal(ImpNetoGravado);
                        }
                        ///// Calculo al %21
                        string Valor2 = Convert.ToString(Math.Round((ImpNetoGravado * 0.21), 2));
                        decimal resultado2 = Convert.ToDecimal(Valor2);
                        if (resultado2 == Iva)
                        {
                            list.Total2 = Convert.ToDecimal(list.Monto);
                            list.Iva2 = Convert.ToDecimal(Iva);
                            list.Neto2 = Convert.ToDecimal(ImpNetoGravado);
                        }
                        ///// Calculo al %27
                        string Valor3 = Convert.ToString(Math.Round((ImpNetoGravado * 0.27), 2));
                        decimal resultado3 = Convert.ToDecimal(Valor3);
                        if (resultado3 == Iva)
                        {
                            list.Total3 = Convert.ToDecimal(list.Monto);
                            list.Iva3 = Convert.ToDecimal(Iva);
                            list.Neto3 = Convert.ToDecimal(ImpNetoGravado);
                        }

                        else
                        {
                            ///// Calculo al %10,5
                            var trncateCalculo1 = ImpNetoGravado * 0.105;
                            trncateCalculo1 = Math.Truncate(trncateCalculo1 * 100) / 100;
                            decimal TruncateResultado1 = Convert.ToDecimal(trncateCalculo1);
                            if (TruncateResultado1 == Iva)
                            {
                                list.Total1 = Convert.ToDecimal(list.Monto);
                                list.Iva1 = Convert.ToDecimal(Iva);
                                list.Neto1 = Convert.ToDecimal(ImpNetoGravado);
                            }
                            ///// Calculo al %21
                            var trncateCalculo2 = ImpNetoGravado * 0.21;
                            trncateCalculo2 = Math.Truncate(trncateCalculo2 * 100) / 100;
                            decimal TruncateResultado2 = Convert.ToDecimal(trncateCalculo2);
                            if (TruncateResultado2 == Iva)
                            {
                                list.Total2 = Convert.ToDecimal(list.Monto);
                                list.Iva2 = Convert.ToDecimal(Iva);
                                list.Neto2 = Convert.ToDecimal(ImpNetoGravado);
                            }
                            ///// Calculo al %27
                            var trncateCalculo3 = ImpNetoGravado * 0.27;
                            trncateCalculo3 = Math.Truncate(trncateCalculo3);
                            decimal TruncateResultado3 = Convert.ToDecimal(trncateCalculo3);
                            if (TruncateResultado3 == Iva)
                            {
                                list.Total3 = Convert.ToDecimal(list.Monto);
                                list.Iva3 = Convert.ToDecimal(Iva);
                                list.Neto3 = Convert.ToDecimal(ImpNetoGravado);
                            }
                        }
                    }
                    ////// Agrego Percepcionj Iva e Ingresos Brutos
                    list.PercepIva = 0;
                    list.PercepIngBrutos = 0;
                    dataGridView1.Visible = true;
                    listaSubCliente.Add(list);
                    var contadortotal = listaSubCliente.Count;
                    label4.Visible = true;
                    label5.Visible = true;
                    label4.Text = Convert.ToString(contadortotal);
                    //ListaPrecargada = listaSubCliente;
                    dataGridView1.Rows.Add(list.Fecha, list.TipoComprobante, list.NroFactura, list.TipoComprobante, list.Cuit, list.NombreProveedor, list.TipoDeCambio, list.CodigoMoneda, VARImpNetoGravado, VARImpNetoNoGravado, VARImpOpExentas, list.PercepIva, list.PercepIngBrutos, Iva, list.Monto);
                }
                ListaStatic = listaSubCliente;
                ValidarDiseñoGrilla();
                btnCargaMasiva.Visible = true;
            }
        }
        private void ValidarDiseñoGrilla()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                decimal netoGravado = Convert.ToDecimal(row.Cells[8].Value);
                decimal NetoNoGravado = Convert.ToDecimal(row.Cells[9].Value);
                decimal Exentas = Convert.ToDecimal(row.Cells[10].Value);
                decimal IVA = Convert.ToDecimal(row.Cells[13].Value);
                decimal Monto = Convert.ToDecimal(row.Cells[14].Value);
                decimal PercIva = 0;
                decimal PercIngBrutos = 0;
                if (row.Cells[11].Value != null)
                { PercIva = Convert.ToDecimal(row.Cells[11].Value); }
                else { PercIva = 0; }
                if (row.Cells[12].Value != null)
                { PercIngBrutos = Convert.ToDecimal(row.Cells[12].Value); }
                else { PercIngBrutos = 0; }
                decimal ValidarMonto = netoGravado + NetoNoGravado + Exentas + IVA + PercIva + PercIngBrutos;
                decimal ValidarMontoTotal = Convert.ToDecimal(ValidarMonto);
                if (ValidarMontoTotal > Monto || ValidarMontoTotal < Monto)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }

                else { row.DefaultCellStyle.BackColor = Color.White; }
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Actualizar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell BotonVer = this.dataGridView1.Rows[e.RowIndex].Cells["Actualizar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"signo-de-dolar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 5);
                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;
                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 15)
            {
                ValidarDiseñoGrilla();
            }
        }
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            try
            {
                Calculos(ListaStatic);
                ProgressBar();
                string Periodo = cmbPeriodo.Text;
                int Exito = ComprasNeg.GuardarCargaMasivaCompras(ListaStatic, cuit, Periodo);
                if (Exito > 0)
                {
                    string Numero = Convert.ToString(Exito);
                    string message2 = "Se registraron '" + Numero + "' facturas exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
                if (Exito == 0)
                {

                    string message2 = "Las facturas que intento cargar ya se encontraban registradas.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }
                if (Exito != 0 && Exito < 0)
                {
                    const string message2 = "Algo falló.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { }
        }
    }
}

