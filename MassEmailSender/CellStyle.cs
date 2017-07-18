using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEmailSender
{
    public class CellStyle
    {
        public Border Border { get; set; }
        public ExcelFont Font { get; set; }
        public ExcelFill Fill { get; set; }
        public ExcelNumberFormat NumberFormat { get; set; }
        public ExcelHorizontalAlignment HAlignment { get; set; }
        public ExcelVerticalAlignment VAlignment { get; set; }
        public CellStyle(ExcelStyle style)
        {
            Border = style.Border;
            Font = style.Font;
            Fill = style.Fill;
            NumberFormat = style.Numberformat;
            HAlignment = style.HorizontalAlignment;
            VAlignment = style.VerticalAlignment;
        }
        public void SetStyle(ExcelStyle style)
        {
            style.Fill.PatternType = ExcelFillStyle.Solid;
            style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
            //style.Border = Border;
            //style.Font = Font;
            //style.Fill = Fill;
            //style.Numberformat = NumberFormat;
            //style.VerticalAlignment = VAlignment;
            //style.HorizontalAlignment = HAlignment;
        }
    }
}
