using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");

        }
        public IActionResult StaticCustomerReport()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfpTable = new PdfPTable(3);
            pdfpTable.AddCell("Misafir Adı");
            pdfpTable.AddCell("Misafir Soyadı");
            pdfpTable.AddCell("Misafir TC");

            pdfpTable.AddCell("Eylül");
            pdfpTable.AddCell("Yücedağ");
            pdfpTable.AddCell("11111111110");

            pdfpTable.AddCell("Kemal");
            pdfpTable.AddCell("Yıldırım");
            pdfpTable.AddCell("22222222222");

            pdfpTable.AddCell("MEhmet");
            pdfpTable.AddCell("Yücedağ");
            pdfpTable.AddCell("44444444444");

            document.Add(pdfpTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");


        }
    }
}
