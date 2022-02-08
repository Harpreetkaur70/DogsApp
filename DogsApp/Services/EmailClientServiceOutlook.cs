using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Services
{
    class EmailClientServiceOutlook : IEmailClientService
    {
        public Task<bool> SendEmail(string To, string From, string Subject, string Body)
        {
            //Awesome outlook email code here.
            throw new NotImplementedException();
        }
    }
}
