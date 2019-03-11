using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using htx_web.Reports;
using Microsoft.AspNetCore.Mvc;

namespace htx_web.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            PDFFormService.Instance.FillForm("Reports/Templates/YeuCauTraNo.pdf",
                "Reports/Output/YeuCauTraNo.pdf", new Dictionary<string, string>()
            {
                { "Date", "10"},
                { "Month", "3"},
                {"Year", "2019" },
                { "CompanyName", "Công ty TNHH Cái Lồn"},
                { "Address", "Phú Lễ, Quảng Phú, Quảng Điền, Thừa Thiên Huế"},
                { "CompanyAccountName", "XYZ Company"},
                { "AccountNumber", "0123368544"},
                { "BankName", "Agribank"},
                { "BankBranchName", "HTX Phu Thuan"},
                { "DirectorName", "Viet Cong Luy"}
            });

            var stream = new FileStream("Reports/Output/YeuCauTraNo.pdf", FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");

            //return View();
        }

        public IActionResult ReportPdf()
        {
            return View();
        }
    }
}