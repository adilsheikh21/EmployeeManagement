using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructures.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Managers
{
    public class EmailManager : IEmailManager
    {
        private readonly IEmailService _emailService;

        public EmailManager(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task SendInvoiceAsync(string email,string attachmentPath)
        {
            await _emailService.SendWithAttachmentAsync(email , "Invoice","test" , attachmentPath);
        }
    }
}
