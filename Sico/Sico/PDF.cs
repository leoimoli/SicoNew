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
        }

        public override void OnCloseDocument(PdfWriter writer, Document doc)
        {
            base.OnCloseDocument(writer, doc);
        }
    }
}
