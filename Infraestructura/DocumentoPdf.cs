using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
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

        public void GuardarVentas(List<Venta> ventas, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("DELISOFT APP");
            document.Open();
            document.Add(new Paragraph("FACTURA DE VENTA"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTablaVentas(ventas));
            document.Close();
        }

        private PdfPTable LlenarTablaVentas(List<Venta> ventas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Subtotal"));
            tabla.AddCell(new Paragraph("Iva aplicado"));
            tabla.AddCell(new Paragraph("Decuento aplicado"));
            tabla.AddCell(new Paragraph("Valor total"));
            foreach (Venta venta in ventas)
            {
                tabla.AddCell(new Paragraph(venta.IdVenta));
                tabla.AddCell(new Paragraph(venta.Subtotal.ToString()));
                tabla.AddCell(new Paragraph(venta.IvaAplicado.ToString()));
                tabla.AddCell(new Paragraph(venta.DescuentoAplicado.ToString()));
                tabla.AddCell(new Paragraph(venta.ValorTotal.ToString()));
            }
            return tabla;
        }
    }
}
