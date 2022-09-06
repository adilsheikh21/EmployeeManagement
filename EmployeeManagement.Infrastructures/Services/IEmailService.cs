using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructures.Services
{
    public interface IEmailService
    {
        
        Task SendAsync(string receiver, string senderName, string senderEmail, string subject, string mailBody);

        Task SendWithAttachmentAsync(string email, string subject, string mailBody, string path);



    }
}
