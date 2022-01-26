using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDependencyInjectionSample.Services {
    internal interface ISender {
        void Send(Customer customer, string message);
    }
}
