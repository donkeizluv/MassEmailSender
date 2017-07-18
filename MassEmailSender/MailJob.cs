using OfficeOpenXml;

namespace MassEmailSender
{
    public class MailJob
    {
        public ExcelWorksheet Sheet { get; set; }
        public string Group { get; set; }
        public string SheetName { get; set; }

        public MailJob(ExcelWorksheet sheet, string sheetName, string group)
        {
            Sheet = sheet;
            SheetName = sheetName;
            Group = group;
        }

        public object[] ToObjectArray()
        {
            return new object[2] { Sheet, Group };
        }
    }
}