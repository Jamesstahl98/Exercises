using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadOrderAppRefactored.Core.Interfaces
{
    internal interface INotificationService
    {
        void Send(string type, string message, string email);
       
     }
}
