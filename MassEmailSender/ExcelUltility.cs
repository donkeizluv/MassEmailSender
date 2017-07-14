//using Microsoft.Office.Interop.Excel;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MassEmailSender.Properties;
//using System.Runtime.InteropServices;

//namespace MassEmailSender
//{
//    public struct NameMapping
//    {
//        public string Name;
//        public List<int> Map;
//    }
//    public class ExcelUltility : IDisposable
//    {
//        public int LastRow { get; private set; }
//        public int LastCol { get; private set; }
//        private Application _app;
//        private Workbook _wb;
//        private Worksheet _wsh;
//        private object[,] _contentArray;

//        public ExcelUltility(string path)
//        {
//            _app = new Application();
//            _wb = _app.Workbooks.Open(path, false, true);
//            _wsh = _wb.Worksheets[1]; //take first worksheet
//            var last = _wsh.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing);
//            //select all visible data
//            var range = _wsh.get_Range("A1", last);
//            LastRow = last.Row;
//            LastCol = last.Column;
//            _contentArray = range.Value as object[,];
//        }
//        //NYI: use CSS
//        private string MakeTableHeaders()
//        {
//            string headerHtml = "<tr><br>";
//            for (int i = 1; i <= _contentArray.GetLength(1); i++)
//            {
//                string val = _contentArray[1, i] == null ? string.Empty : _contentArray[1, i].ToString();
//                //if (val == string.Empty) continue; //should allow empty header
//                headerHtml += string.Format("{0}<b>{1}</b></td>", Resources.OpenCellHTML, val);
//            }
//            headerHtml += "</br></tr>";
//            return headerHtml;
//        }
//        //slowwwwwwww
//        public string BuildHTMLTable(string headerName, string uniqueName)
//        {
//            string tableHTML = string.Empty;
//            int headerIndex = FindHeaderIndex(headerName);
//            int rowCount = 0;
//            //int occurrent = CountOccurrent(headerIndex, uniqueName);

//            tableHTML = Resources.OpenTableHTML + MakeTableHeaders();
//            //row iteration
//            for (int i = 1; i <= _contentArray.GetLength(0); i++)
//            {
//                string value = _contentArray[i, headerIndex] == null ? string.Empty : _contentArray[i, headerIndex].ToString();
//                if (value == string.Empty) continue;
//                //found match
//                if(string.Compare(value, uniqueName) == 0)
//                {
//                    tableHTML += "<tr>";
//                    //column iteration
//                    for (int ii = 1; ii <= _contentArray.GetLength(1); ii++)
//                    {
//                        string cellContent = _contentArray[i, ii] == null ? string.Empty : _contentArray[i, ii].ToString();
//                        tableHTML += string.Format("{0}{1}</td>", Resources.OpenCellHTML, cellContent);
//                    }
//                    tableHTML += "</tr>";
//                    rowCount++;
//                }
//            }
//            tableHTML += "</table>";
//            return tableHTML;
//        }
//        public string BuildHTMLTable(string headerName, NameMapping nameMap)
//        {
//            string tableHTML = string.Empty;
//            int headerIndex = FindHeaderIndex(headerName);
//            int rowCount = 0;
//            //int occurrent = CountOccurrent(headerIndex, uniqueName);

//            tableHTML = Resources.OpenTableHTML + MakeTableHeaders();
//            //row iteration
//            foreach (var index in nameMap.Map)
//            {
//                tableHTML += "<tr>";
//                for (int ii = 1; ii <= _contentArray.GetLength(1); ii++)
//                {
//                    string cellContent = _contentArray[index, ii] == null ? string.Empty : _contentArray[index, ii].ToString();
//                    tableHTML += string.Format("{0}{1}</td>", Resources.OpenCellHTML, cellContent);
//                }
//                tableHTML += "</tr>";
//                rowCount++;
//            }
//            tableHTML += "</table>";
//            return tableHTML;
//        }
//        public List<string> GetHeaders()
//        {
//            var list = new List<string>();
//            //interop excel type is usually 1 based index
//            for (int i = 1; i <= _contentArray.GetLength(1); i++)
//            {
//                string val = _contentArray[1, i] == null ? string.Empty : _contentArray[1, i].ToString();
//                if (val == string.Empty) continue;
//                list.Add(val);
//            }
//            return list;
//        }

//        public List<string> GetUniqueValues(string headerName)
//        {
//            var list = new List<string>();
//            int colIndex = FindHeaderIndex(headerName);
//            for (int i = 1; i <= _contentArray.GetLength(0); i++)
//            {
//                string value = _contentArray[i, colIndex] == null ? string.Empty : _contentArray[i, colIndex].ToString();
//                if (value == string.Empty || value == headerName) continue;
//                if (!list.Contains(value))
//                {
//                    list.Add(value);
//                }
//            }
//            return list;
//        }

//        public List<NameMapping> GetUniqueValueMapping(string headerName)
//        {
//            var listNameMapping = new List<NameMapping>();
//            int colIndex = FindHeaderIndex(headerName);
//            for (int i = 1; i <= _contentArray.GetLength(0); i++)
//            {
//                string value = _contentArray[i, colIndex] == null ? string.Empty : _contentArray[i, colIndex].ToString();
//                if (value == string.Empty || value == headerName) continue; //skip header row


//                var found = listNameMapping.FirstOrDefault(item => item.Name == value);
//                if (found.Name == null) //new name & map
//                {
//                    var nameMap = new NameMapping();
//                    nameMap.Name = value;
//                    nameMap.Map = new List<int>();
//                    nameMap.Map.Add(i);
//                    listNameMapping.Add(nameMap);
//                }
//                else //add to map
//                {
//                    found.Map.Add(i);
//                }

//            }
//            return listNameMapping;
//        }
//        private int CountOccurrent(int headerIndex, string uniqueName)
//        {
//            int count = 0;
//            for (int i = 1; i <= _contentArray.GetLength(0); i++)
//            {
//                string value = _contentArray[i, headerIndex] == null ? string.Empty : _contentArray[i, headerIndex].ToString();
//                if (value == string.Empty) continue;
//                if (string.Compare(uniqueName, value) == 0) count++;
//            }
//            return count;
//        }
//        private int FindHeaderIndex(string headerName)
//        {
//            for (int i = 1; i <= _contentArray.GetLength(1); i++)
//            {
//                string val = _contentArray[1, i] == null ? string.Empty : _contentArray[1, i].ToString();
//                if (val == string.Empty) continue;
//                if(string.Compare(val, headerName) == 0)
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }

//        public void Dispose()
//        {
//            _wb.Close(0);
//            ReleaseComObject(_wb);
//            _wb = null;
//            ReleaseComObject(_wsh);
//            _wsh = null;
//            if (_app != null)
//            {
//                _app.Quit();
//            }
//            ReleaseComObject(_app);
//            _app = null;
//        }
//        public static void ReleaseComObject(object obj)
//        {
//            if (obj != null && Marshal.IsComObject(obj))
//            {
//                Marshal.ReleaseComObject(obj);
//            }
//            GC.Collect();
//            GC.WaitForPendingFinalizers();
//            GC.Collect();
//            GC.WaitForPendingFinalizers();
//        }
//    }
//}
