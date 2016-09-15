using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPDevelopment.Services
{
    public class DebugMailService : IMailService
    {
        public bool SendMail(string to, string from, string subject, string body)
        {
            try
            {
                Debug.WriteLine($"Sending mail: To: {to}, Subject: {subject} ");
                return true;
            }
            catch (Exception)
            {
                
                throw new NotImplementedException();
        }
            }
           
    }
}
