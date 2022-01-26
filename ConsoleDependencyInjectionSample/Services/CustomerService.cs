using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDependencyInjectionSample.Repositories;

namespace ConsoleDependencyInjectionSample.Services {
    internal class CustomerService {
        //private CustomerRepository _repository;
        private IRepository _repository;
        //public CustomerService() {
        //    _repository = new CustomerRepository();
        //}
        public CustomerService(IRepository repository) {
            _repository = repository;
        }
        public List<Customer> GetCustomers() {
            return _repository.GetCustomers();
        }
    }
}
