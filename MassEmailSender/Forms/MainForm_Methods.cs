using MimeKit;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MassEmailSender.Forms
{
    public partial class FormMain
    {
        private const string TempFolderName = "temp";
        private const string EmailContentFolder = "content";
        private const string EmailSubjectFile = "subject.txt";
        private const string EmailContentFile = "body.txt";
        private const string HdssEmail = "@hdsaison.com.vn";

        //public string DefaultSuffix
        //{
        //    get
        //    {
        //        return textBoxSuffix.Text;
        //    }
        //}

        private List<MimeMessage> MakeEmails(Dictionary<string, List<string>> mailAttatchmentDict)
        {
            var emails = new List<MimeMessage>();
            foreach (var pair in mailAttatchmentDict)
            {
                var email = new MimeMessage();
                var attList = new List<MimePart>();
                foreach (var att in pair.Value)
                {
                    attList.Add(MakeAttachment(att));
                }
                AddSenderNRecipient(email, pair.Key);
                var multipart = new Multipart("mixed");
                foreach (var att in attList)
                {
                    multipart.Add(att);
                }
                multipart.Add(MakeBodyPart());
                email.Body = multipart;
                email.Subject = _subject;
                emails.Add(email);
            }
            return emails;
        }
        
        private bool CheckHdssEmail(Dictionary<string, List<string>> dict, MailJob job)
        {
            bool flag = true;
            foreach (var pair in dict)
            {
                if(!pair.Key.Contains(HdssEmail))
                {
                    _logger.Log($"Illegal email -> sheet: {job.SheetName} | value: {pair.Key}");
                    flag = false;
                }
            }
            return flag;
        }
        private Dictionary<string, List<string>> MakeExcelFiles(List<MailJob> jobs, ExcelPackage package)
        {
            //check if folder exists
            Directory.CreateDirectory($"{Program.ExeDir}\\{TempFolderName}");
            var dict = new Dictionary<string, List<string>>();
            bool valid = true;
            foreach (var job in jobs)
            {
                var contentDict = ExcelUltility.MapContentAddress(package.Workbook.Worksheets[job.SheetName], job.Group);
                if (!CheckHdssEmail(contentDict, job))
                {
                    valid = false;
                    continue;
                }

                foreach (var group in contentDict)
                {
                    string fullFilename = $"{Program.ExeDir}\\{TempFolderName}\\" +
                        $"{StripIlligalChar(group.Key)}-{StripIlligalChar(job.SheetName)}-{RandomString(6)}.xlsx";
                    if (!ExcelUltility.WriteExcel(fullFilename, job.SheetName, group.Value, job.Sheet))
                    {
                        //TODO: handle this!
                        throw new Exception("wtf?");
                    }
                    //add to dict
                    AddOrCreateNewList(dict, group.Key, fullFilename);
                }
            }
            if (!valid)
                throw new InvalidDataException("Invalid email.");
            return dict;
        }
        public static void AddOrCreateNewList<T>(Dictionary<string, List<T>> dict, string key, T item)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(item);
            }
            else
            {
                dict.Add(key, new List<T> { item });
            }
        }

        private string StripIlligalChar(string email)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            string returnString = email.Replace(HdssEmail, "").Replace("-", "").Replace(".", "");
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                returnString = returnString.Replace(c, '_');
            }
            return returnString;
        }

        private MimePart MakeAttachment(string fullFilename)
        {
            if (string.IsNullOrEmpty(fullFilename))
                throw new ArgumentException("attachment file name is null or empty");
            var attachment = new MimePart("text", "plain")
            {
                ContentObject = new ContentObject(File.OpenRead(fullFilename), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(fullFilename)
            };
            return attachment;
        }

        private void AddSenderNRecipient(MimeMessage email, string recipient)
        {
            email.From.Add(new MailboxAddress(CheckSuffix(textBoxSmtpAccountName.Text)));
            if (checkBoxRoute.Checked)
            {
                email.To.Add(new MailboxAddress(textBoxRouteTo.Text));
            }
            else
            {
                email.To.Add(new MailboxAddress(recipient));
            }
            if (textBoxCc.Text.Length > 0)
                email.Cc.Add(new MailboxAddress(textBoxCc.Text));
        }

        private TextPart MakeBodyPart()
        {
            var part = new TextPart("plain");
            part.Text = _body;
            return part;
        }

        private string CheckSuffix(string address)
         => address.Contains("@") ? address : address + HdssEmail;

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}