using Log;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MassEmailSender
{
    public static class ExcelUltility
    {
        private static ILogger _logger = LogManager.GetLogger(typeof(ExcelUltility));
        /// <summary>
        /// 1st row is header, group all content to dict
        /// </summary>
        /// <param name="sheet">sheet to group</param>
        /// <param name="groupColumn">column which value is used to group to Dict key</param>
        /// <returns></returns>
        public static Dictionary<string, List<List<string>>> MapContent(ExcelWorksheet sheet, string groupColumn, bool includeHeader = true)
        {
            var rowCount = sheet.Dimension.End.Row;
            var colCount = sheet.Dimension.End.Column;
            var headerRow = GetFirstRow(sheet).ToList();
            int FindHeaderIndex(string header)
            {
                for (int i = 1; i <= colCount; i++)
                {
                    if (sheet.Cells[1, i].Value == null) continue;
                    if (string.Compare(sheet.Cells[1, i].Value.ToString(), header, true) == 0) return i;
                }
                return -1;
            }
            int headerColIndex = FindHeaderIndex(groupColumn);
            if (headerColIndex == -1) throw new ArgumentException($"Cant find index of header: {groupColumn}");
            var dict = new Dictionary<string, List<List<string>>>();
            for (int rowIndex = 2; rowIndex <= rowCount; rowIndex++)
            {
                var cell = sheet.Cells[rowIndex, headerColIndex];
                if (cell.Value == null) continue;
                var key = cell.Value.ToString().Trim();
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key)) continue;
                var rowContent = new List<string>();
                for (int colIndex = 1; colIndex <= colCount; colIndex++)
                {
                    var value = sheet.Cells[rowIndex, colIndex].Value;
                    string content = value == null ? string.Empty : value.ToString();
                    rowContent.Add(content);
                }
                //add to dict
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(rowContent);
                }
                else
                {
                    if (includeHeader)
                    {
                        //add header row
                        dict.Add(key, new List<List<string>>() { headerRow, rowContent });
                    }
                    else
                    {
                        dict.Add(key, new List<List<string>>() { rowContent });
                    }
                }
            }
            return dict;
        }

        /// <summary>
        /// 1st row is header, group all content to dict
        /// </summary>
        /// <param name="sheet">sheet to group</param>
        /// <param name="groupColumn">column which value is used to group to Dict key</param>
        /// <returns></returns>
        public static Dictionary<string, List<string>> MapContentAddress(ExcelWorksheet sheet, string groupColumn, bool includeHeader = true)
        {
            var rowCount = sheet.Dimension.End.Row;
            var colCount = sheet.Dimension.End.Column;
            //var headerRow = GetFirstRow(sheet).ToList();
            int FindHeaderIndex(string header)
            {
                for (int i = 1; i <= colCount; i++)
                {
                    if (sheet.Cells[1, i].Value == null) continue;
                    if (string.Compare(sheet.Cells[1, i].Value.ToString(), header, true) == 0) return i;
                }
                return -1;
            }
            int headerColIndex = FindHeaderIndex(groupColumn);
            if (headerColIndex == -1) throw new ArgumentException($"Cant find index of header: {groupColumn}");
            var list = new Dictionary<string, List<string>>();
            for (int rowIndex = 2; rowIndex <= rowCount; rowIndex++)
            {
                var cell = sheet.Cells[rowIndex, headerColIndex];
                if (cell.Value == null) continue;
                var key = cell.Value.ToString().Trim();
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key)) continue;
                string address = sheet.Cells[rowIndex, 1, rowIndex, colCount].Address;
                //add to dict
                if (list.ContainsKey(key))
                {
                    list[key].Add(address);
                }
                else
                {
                    if (includeHeader)
                    {
                        //add header row
                        list.Add(key, new List<string>() { sheet.Cells[1, 1, 1, colCount].Address, address });
                    }
                    else
                    {
                        list.Add(key, new List<string>() { address });
                    }
                }
            }
            return list;
        }
     
        public static IEnumerable<string> GetSheetNames(ExcelPackage package)
        {
            var list = new List<string>();
            foreach (var sheet in package.Workbook.Worksheets)
            {
                list.Add(sheet.Name);
            }
            return list;
        }
        //nope
        //public static IEnumerable<CellStyle> GetRowStyles(ExcelWorksheet sheet, int row, int count)
        //{
        //    var list = new List<CellStyle>();
        //    for (int i = 1; i <= count; i++)
        //    {
        //        list.Add(new CellStyle(sheet.Cells[row, i].Style));
        //    }
        //    return list;
        //}
        public static IEnumerable<string> GetFirstRow(ExcelWorksheet sheet)
        {
            //var rowCnt = sheet.Dimension.End.Row;
            var colCnt = sheet.Dimension.End.Column;
            var list = new List<string>();
            for (int i = 1; i <= colCnt; i++)
            {
                if (sheet.Cells[1, i].Value == null) continue;
                list.Add(sheet.Cells[1, i].Value.ToString());
            }
            return list;
        }
        /// <summary>
        /// write to new excel file, copy method (preserve format)
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="sheetName"></param>
        /// <param name="addressList"></param>
        /// <param name="copyFromSheet"></param>
        /// <param name="progress"></param>
        /// <param name="fitAllCol"></param>
        /// <returns></returns>
        public static async Task WriteExcelAsync(string fullName, string sheetName, List<string> addressList, ExcelWorksheet copyFromSheet, IProgress<int> progress, bool fitAllCol = true)
        {
            await Task.Run(() => WriteExcel(fullName, sheetName, addressList, copyFromSheet, progress, fitAllCol));
        }
        /// <summary>
        /// write to new excel file, copy method (preserve format)
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="sheetName"></param>
        /// <param name="addressList"></param>
        /// <param name="copyFromSheet"></param>
        /// <param name="progress"></param>
        /// <param name="fitAllCol"></param>
        /// <returns></returns>
        public static void WriteExcel(string fullName, string sheetName, List<string> addressList, ExcelWorksheet copyFromSheet, IProgress<int> progress, bool fitAllCol = true)
        {
            using (var package = new ExcelPackage(new System.IO.FileInfo(fullName)))
            {
                var sheet = package.Workbook.Worksheets.Add(sheetName);
                int row = 1;
                foreach (var address in addressList)
                {
                    try
                    {
                        CleanInvalidStyles(copyFromSheet, address);
                        copyFromSheet.Cells[address].Copy(sheet.Cells[row, 1], ExcelRangeCopyOptionFlags.ExcludeFormulas);
                    }
                    catch (ArgumentOutOfRangeException) //clean style then try again
                    {
#if DEBUG
                        Debug.Print($"{address} contains invalid styles");
#endif
                        //update invalids
                        UpdateInvalidStylesCache(copyFromSheet, address);
                        CleanInvalidStyles(copyFromSheet, address);
                        //try again
                        copyFromSheet.Cells[address].Copy(sheet.Cells[row, 1], ExcelRangeCopyOptionFlags.ExcludeFormulas);
                    }
                    progress?.Report(row * 100 / addressList.Count);
                    row++;
                }
                if (fitAllCol)
                {
                    sheet.Cells[sheet.Dimension.Address].AutoFitColumns();
                }
                package.Save();
            }
        }
        private static readonly List<string> InvalidStylesCache = new List<string>();
        private static void UpdateInvalidStylesCache(ExcelWorksheet ws, string address)
        {
            using (var testPackage = new ExcelPackage())
            {
                var testExcelWorksheet = testPackage.Workbook.Worksheets.Add("test");
                for (int row = ws.Cells[address].Start.Row; row < ws.Cells[address].Rows + ws.Cells[address].Start.Row; row++)
                {
                    for (int col = 1; col <= ws.Cells[address].Columns; col++)
                    {
                        //skip if already been cached
                        if (InvalidStylesCache.Contains(ws.Cells[row, col].StyleName))
                        {
#if DEBUG
                            Debug.Print($"{ws.Cells[row, col].StyleName} already cached -> skip check");
#endif
                            continue;
                        }
                        //test for exception
                        try
                        {
                            ws.Cells[row, col].Copy(testExcelWorksheet.Cells[1, 1]);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            InvalidStylesCache.Add(ws.Cells[row, col].StyleName);
#if DEBUG
                            Debug.Print($"cache new invalid style: {ws.Cells[row, col].StyleName}");
#endif
                        }
                    }
                }
            }
        }
        private static void CleanInvalidStyles(ExcelWorksheet ws, string address, string resetTo = "Normal")
        {
            for (int row = ws.Cells[address].Start.Row; row < ws.Cells[address].Rows + ws.Cells[address].Start.Row; row++)
            {
                for (int col = 1; col <= ws.Cells[address].Columns; col++)
                {
                    if(InvalidStylesCache.Contains(ws.Cells[row, col].StyleName))
                    {
#if DEBUG
                        Debug.Print($"Cleaned: {ws.Cells[row, col].StyleName} -> {resetTo}");
#endif
                        ws.Cells[row, col].StyleName = resetTo;
                    }
                }
            }
        }
        //private static void CleanHyperlinkStyleShit(ExcelWorksheet ws, string address)
        //{
        //    //for some fucking unknown reason
        //    //ExcelRange ref object sometimes doesnt hold the correct infomation
        //    //so i have to use ws.Cells[address] everywhere
        //    for (int row = ws.Cells[address].Start.Row; row < ws.Cells[address].Rows + ws.Cells[address].Start.Row; row++)
        //    {
        //        for (int col = 1; col <= ws.Cells[address].Columns; col++)
        //        {
        //            if (string.Compare(ws.Cells[row, col].StyleName, "Hyperlink") == 0)
        //                ws.Cells[row, col].StyleName = "Normal";
        //        }
        //    }
        //}

        //write list to new excel file
        public static bool WriteExcel(string fullName, string sheetName, List<List<string>> contentArray)
        {
            var array = new List<object[]>();
            foreach (var item in contentArray)
            {
                array.Add(item.ToArray());
            }
            return WriteExcel(fullName, sheetName, array);
        }

        public static bool WriteExcel(string fullName, string sheetName, IEnumerable<object[]> contentArray)
        {
            using (var package = new ExcelPackage(new System.IO.FileInfo(fullName)))
            {
                var sheet = package.Workbook.Worksheets.Add(sheetName);
                sheet.Cells.LoadFromArrays(contentArray);
                package.Save();
            }
            return true;
        }
    }
}