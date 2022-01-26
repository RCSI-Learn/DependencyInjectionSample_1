using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDependencyInjectionSample.Services {
    internal class CommunicationService {
        //private EmailService _eMailService;
        //public CommunicationService() {
        //    _eMailService = new EmailService();
        //}
        //public void SendMessage(Customer customer, string message) {
        //    _eMailService.Send(customer, message);
        //}

        private ISender _sender;
        public CommunicationService(ISender sender) {
            _sender = sender;
        }
        public void SendMessage(Customer customer, string message) { 
            _sender.Send(customer, message);
        }
    }
}
