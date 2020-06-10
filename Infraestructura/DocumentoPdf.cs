using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(List<Vendedor> vendedores, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("DELISOFT APP");
            document.Open();
            document.Add(new Paragraph("VENDEDORES"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(vendedores));
            document.Close();
        }
        private PdfPTable LlenarTabla(List<Vendedor> vendedores)
        {
            PdfPTable tabla = new PdfPTable(2);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            foreach (Vendedor vendedor in vendedores)
            {
                tabla.AddCell(new Paragraph(vendedor.IdVendedor));
                tabla.AddCell(new Paragraph(vendedor.NombreVendedor));
            }
            return tabla;
        }


    }
}
