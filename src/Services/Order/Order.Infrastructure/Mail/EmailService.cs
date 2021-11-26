using Order.Application.Contracts.Infrastructure;
using Order.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public Task<bool> SendEmail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
