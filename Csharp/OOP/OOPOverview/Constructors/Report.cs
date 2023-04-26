namespace Constructors
{
    public enum ReportFormatType
    {
        HTML,
        PDF
    }
    public class Report
    {
        /*
         * Excel dosyasından verileri okuyup belirtilen formatta bir rapor dokümanına dönüştürecek.
         */
        public string ExcelFilePath { get; set; }
        public ReportFormatType ReportDocumentFormat { get; set; }
        public bool? IsSigned { get; set; }

        public Report(string pathOfExcelFile) : this(pathOfExcelFile, ReportFormatType.PDF)
        {

        }

        public Report(string pathOfExcelFile, ReportFormatType formatType, bool? isSigned = null)
        {
            ExcelFilePath = pathOfExcelFile;
            ReportDocumentFormat = formatType;
            IsSigned = isSigned;
        }




    }
}
