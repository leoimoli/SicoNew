using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico
{
    public class PDF : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document doc)
        {
            base.OnEndPage(writer, doc);
            iTextSharp.text.Font _miniFont = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 6,
                    iTextSharp.text.Font.NORMAL,
                    BaseColor.BLACK);
            iTextSharp.text.Font _microFont = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 5,
                    iTextSharp.text.Font.NORMAL,
                    BaseColor.BLACK);
            iTextSharp.text.Rectangle page = doc.PageSize;

            //  //Cabecera
            //  PdfPTable tbHeader = new PdfPTable(3);
            //  tbHeader.TotalWidth = page.Width - doc.LeftMargin - doc.RightMargin;
            //  tbHeader.DefaultCell.Border = 0;

            //  tbHeader.AddCell(new Paragraph());

            //  PdfPCell _cel = new PdfPCell(new Phrase("SICO: Sistema Contable"));

            //  tbHeader.AddCell(_cel);
            //  _cel.HorizontalAlignment = Element.ALIGN_CENTER;
            //  _cel.Border = 0;


            //  //  C1.VerticalAlignment = Element.ALIGN_TOP;
            //  //  C1.HorizontalAlignment = Element.ALIGN_LEFT;
            //  //  cabecera.AddCell(C1);
            //  tbHeader.WriteSelectedRows(
            //  0, -1,
            //  doc.LeftMargin,
            //  doc.BottomMargin - 10,
            //  writer.DirectContent
            //);

            Font _standardFont = new Font(Font.FontFamily.TIMES_ROMAN, 8, Font.BOLD, BaseColor.BLACK);
            Font _standardFontFooter = new Font(Font.FontFamily.TIMES_ROMAN, 7, Font.BOLD, BaseColor.BLACK);
            PdfPCell _cell;

            try
            {
                ////Indicamos donde esta guardada la imagen
                //string directorioRaiz_Img = "~/Imagenes/";
                //string NombreArchivoImg = "ESCUDO_2019_VERSION_1_Vertical_opt_500X500px.png";
                #region test
                //Image img_LogoMty = Image.GetInstance(System.Web.HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["LOGO_MTY_DOC"].ToString()));
                string pathImagen = @"Imagen_Sico_Login1.png";
                Image img_LogoMty = Image.GetInstance(pathImagen);
                img_LogoMty.BorderWidth = 0;
                img_LogoMty.Alignment = Image.TEXTWRAP | Element.ALIGN_LEFT;
                float percentage = 0.0f;
                percentage = 49 / img_LogoMty.Width;
                //img_LogoMty.SpacingBefore = 15f;
                //img_LogoMty.IndentationLeft = 9f;
                img_LogoMty.ScalePercent(percentage * 100);

                #endregion
                #region HEADER
                PdfPTable tbHeader = new PdfPTable(3);
                tbHeader.TotalWidth = page.Width - doc.LeftMargin - doc.RightMargin;
                //tbHeader.DefaultCell.Border = 0;

                _cell = new PdfPCell(img_LogoMty/*new Paragraph("INSERTE LOGO", _standardFont)*/);
                _cell.HorizontalAlignment = Element.ALIGN_LEFT;
                _cell.Border = 0;
                tbHeader.AddCell(_cell);

                //_cell = new PdfPCell(new Paragraph("############ \n ESTADO ANALITICO DEL EJERCICIO DEL PRESUPUESTO DE EGRESOS \n CLASIFICACION ADMINISTRATIVA \n DEL " +  " AL " +  "."));
                _cell = new PdfPCell(new Paragraph("Sico: Sistema Contable"));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                _cell.Border = 0;
                tbHeader.AddCell(_cell);

                _cell = new PdfPCell(new Paragraph(DateTime.Now.ToString("dd/MM/yyyy"), _standardFont));
                _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                _cell.Border = 0;
                tbHeader.AddCell(_cell);

                tbHeader.WriteSelectedRows(0, -1, doc.LeftMargin, writer.PageSize.GetTop(doc.TopMargin) + 30, writer.DirectContent);
                #endregion

                #region FOOTER
                //Footer
                PdfPTable footer = new PdfPTable(2);
                footer.TotalWidth = page.Width - doc.LeftMargin - doc.RightMargin;
                PdfPCell f1 = new PdfPCell(new Phrase("Generado el: " +
                        string.Format("{0:MMM dd, yyyy hh:mm tt}", DateTime.Now),
                        _miniFont));
                PdfPCell f2 = new PdfPCell(new Phrase("Creado por jliCodeSoftware@gmail.com",
                       _microFont));
                f1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                f1.VerticalAlignment = Element.ALIGN_TOP;
                f1.HorizontalAlignment = Element.ALIGN_LEFT;
                f2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                f2.VerticalAlignment = Element.ALIGN_TOP;
                f2.HorizontalAlignment = Element.ALIGN_RIGHT;
                footer.AddCell(f1);
                footer.AddCell(f2);
                footer.WriteSelectedRows(
                  0, -1,
                  doc.LeftMargin,
                  doc.BottomMargin - 10,
                  writer.DirectContent
                );
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public override void OnCloseDocument(PdfWriter writer, Document doc)
        {
            base.OnCloseDocument(writer, doc);
        }
    }
}
