//using Microsoft.Office.Interop.Outlook;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MassEmailSender.Properties;
//using System.Runtime.InteropServices;

//namespace MassEmailSender
//{
//    public class OutlookEmailSender : IDisposable
//        {
//        private Application _app;
//        public OutlookEmailSender()
//        {
//            _app = new Application();
//        }
//        public MailItem ComposeEmail(string sentTo, string htmlBody)
//        {
//            var mailItem = _app.CreateItem(OlItemType.olMailItem) as MailItem;
//            mailItem.To = sentTo;
//            mailItem.BodyFormat = OlBodyFormat.olFormatHTML;
//            //mailItem.HTMLBody = Resources.OpenHTML;
//            //mailItem.HTMLBody += Resources.HeadHTML;
//            //mailItem.HTMLBody += Resources.OpenBodyHTML;
//            //mailItem.HTMLBody += htmlBody;
//            //mailItem.HTMLBody += Resources.CLoseBodyHTML;
//            //mailItem.HTMLBody += Resources.CloseHTML;
//            mailItem.HTMLBody = string.Format("{0}{1}<body>{2}</body></html>", Resources.OpenHTML, Resources.HeadHTML, htmlBody);
//            return mailItem;
//        }

//        public void Dispose()
//        {
//            //if (_app != null)
//            //{
//            //    _app.Quit();
//            //}
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
