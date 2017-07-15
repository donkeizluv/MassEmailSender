using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace MassEmailSender
{
    public partial class FormMain
    {
        private const string TempFolderName = "temp";
        private const string EmailContentFolder = "content";
        private const string EmailSubjectFile = "subject.txt";
        private const string EmailContentFile = "body.txt";
        public string DefaultSuffix
        {
            get
            {
                return textBoxSuffix.Text;
            }
        }
        private List<MailMessage> MakeEmails(Dictionary<string, List<string>> mailAttatchmentDict)
        {
            var emails = new List<MailMessage>();
            foreach (var pair in mailAttatchmentDict)
            {
                var email = new MailMessage();
                foreach (var att in pair.Value)
                {
                    AddAttachment(att, email);
                }
                AddSenderNRecipient(email, pair.Key);
                AddContent(email);
                emails.Add(email);
            }
            return emails;
        }
        private Dictionary<string, List<string>> MakeExcelFiles(List<MailJob> jobs, ExcelPackage package)
        {
            //check if folder exists
            Directory.CreateDirectory($"{Program.ExeDir}\\{TempFolderName}");
            var dict = new Dictionary<string, List<string>>();
            foreach (var job in jobs)
            {
                var contentDict = ExcelUltility.MapContent(package.Workbook.Worksheets[job.Sheet], job.Group);
                foreach (var group in contentDict)
                {
                    string fullFilename = $"{Program.ExeDir}\\{TempFolderName}\\" +
                        $"{StripIlligalChar(group.Key)}-{StripIlligalChar(job.Sheet)}-{RandomString(6)}.xlsx";
                    if (!ExcelUltility.WriteExcel(fullFilename, job.Sheet, group.Value))
                    {
                        //TODO: handle this!
                        throw new Exception("wtf?");
                    }
                    //add to dict
                    if(dict.ContainsKey(group.Key))
                    {
                        dict[group.Key].Add(fullFilename);
                    }
                    else
                    {
                        dict.Add(group.Key, new List<string>() { fullFilename });
                    }
                }
            }
            return dict;
        }
        private string StripIlligalChar(string email)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            string returnString = email.Replace(DefaultSuffix, "").Replace("-", "").Replace(".", "");
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                returnString = returnString.Replace(c, '_');
            }
            return returnString;
        }
        private void AddAttachment(string fullFilename, MailMessage mail)
        {
            if (string.IsNullOrEmpty(fullFilename))
                throw new ArgumentException("attachment file name is null or empty");
            var attachment = new Attachment(fullFilename, MediaTypeNames.Application.Octet);
            var disposition = attachment.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(fullFilename);
            disposition.ModificationDate = File.GetLastWriteTime(fullFilename);
            disposition.ReadDate = File.GetLastAccessTime(fullFilename);
            disposition.FileName = Path.GetFileName(fullFilename);
            disposition.Size = new FileInfo(fullFilename).Length;
            disposition.DispositionType = DispositionTypeNames.Attachment;
            mail.Attachments.Add(attachment);
        }
        //TODO: implement 
        private void AddSenderNRecipient(MailMessage email, string recipient)
        {
            email.From = new MailAddress(CheckSuffix(textBoxSmtpAccountName.Text));
            if(checkBoxRoute.Checked)
            {
                email.To.Add(CheckSuffix(textBoxRouteTo.Text));
            }
            else
            {
                email.To.Add(CheckSuffix(recipient));
            }
            if(textBoxCc.Text.Length > 0)
                email.CC.Add(CheckSuffix(textBoxCc.Text));
        }
        private void AddContent(MailMessage email)
        {
            email.Subject = _subject;
            email.Body = _body;
        }
        private string CheckSuffix(string address)
         => address.Contains("@") ? address : address + DefaultSuffix;

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
