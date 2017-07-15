using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MassEmailSender
{
    public static class ExcelUltility
    {
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
                var key = cell.Value.ToString();
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

        public static IEnumerable<string> GetSheetNames(ExcelPackage package)
        {
            var list = new List<string>();
            foreach (var sheet in package.Workbook.Worksheets)
            {
                list.Add(sheet.Name);
            }
            return list;
        }

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
            try
            {
                using (var package = new ExcelPackage(new System.IO.FileInfo(fullName)))
                {
                    var sheet = package.Workbook.Worksheets.Add(sheetName);
                    sheet.Cells.LoadFromArrays(contentArray);
                    package.Save();
                }
                return true;
            }
            catch (Exception) //TODO: !!!!!!
            {
                throw;
            }
        }
    }
}