using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace htx_web.Reports
{
    public interface IPDFFormService
    {
        /// <summary>
        /// Gets all fields on pdf file.
        /// </summary>
        ICollection GetFormFields(Stream pdfStream);

        /// <summary>
        /// Fill a pdf template by its fields.
        /// </summary>
        void FillForm(string pdfTemplate, string output, Dictionary<string, string> fields, string baseFont = "times.ttf");
    }
}
