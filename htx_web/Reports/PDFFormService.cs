using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace htx_web.Reports
{
    public class PDFFormService : IPDFFormService
    {
        private static PDFFormService _instance;
        public static PDFFormService Instance
        {
            get { return _instance = _instance ?? new PDFFormService(); }
        }

        /// <summary>
        /// Gets all fields on pdf file.
        /// </summary>
        public ICollection GetFormFields(Stream pdfStream)
        {
            PdfReader reader = null;
            try
            {
                PdfReader pdfReader = new PdfReader(pdfStream);
                AcroFields acroFields = pdfReader.AcroFields;
                return acroFields.Fields.Keys;
            }
            finally
            {
                reader?.Close();
            }
        }

        /// <summary>
        /// Fill pdf file with fields.
        /// </summary>
        private Stream FillForm(Stream inputStream, Dictionary<string, string> fields, string baseFont)
        {
            Stream outStream = new MemoryStream();
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            Stream inStream = null;
            try
            {
                pdfReader = new PdfReader(inputStream);
                pdfStamper = new PdfStamper(pdfReader, outStream);
                AcroFields form = pdfStamper.AcroFields;

                var arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), baseFont);
                var arialBaseFont = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                form.AddSubstitutionFont(arialBaseFont);

                foreach (var pair in fields)
                {
                    //form.SetFieldProperty(pair.Key, pair.Value, arialBaseFont, null);
                    form.SetField(pair.Key, pair.Value);
                }

                // set this if you want the result PDF to not be editable. 
                pdfStamper.FormFlattening = true;
                return outStream;
            }
            finally
            {
                pdfStamper?.Close();
                pdfReader?.Close();
                inStream?.Close();
            }
        }

        /// <summary>
        /// Fill a pdf template by its fields.
        /// </summary>
        public void FillForm(string pdfTemplate, string output, Dictionary<string, string> fields, string baseFont = "times.ttf")
        {
            using (Stream pdfInputStream = new FileStream(path: pdfTemplate, mode: FileMode.Open))
            using (Stream resultPDFOutputStream = new FileStream(path: output, mode: FileMode.Create))
            using (Stream resultPDFStream = FillForm(pdfInputStream, fields, baseFont))
            {

                // set the position of the stream to 0 to avoid corrupted PDF. 
                resultPDFStream.Position = 0;
                resultPDFStream.CopyTo(resultPDFOutputStream);
            }
        }
    }
}
