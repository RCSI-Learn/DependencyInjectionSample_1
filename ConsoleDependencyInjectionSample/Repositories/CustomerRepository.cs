using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDependencyInjectionSample.Services;

namespace ConsoleDependencyInjectionSample.Repositories {
    internal class CustomerRepository : IRepository {
        //private MySQLConnection _connection;
        private IDBConnection _connection;
        public CustomerRepository(IDBConnection connection) {
            _connection = connection;
        }
        //public CustomerRepository() {
        //    _connection = new MySQLConnection();
        //}
        public List<Customer> GetCustomers() {
            if (_connection.GetType() == typeof(MySQLConnection)) Console.WriteLine("Get Customers from MySQL");
            if (_connection.GetType() == typeof(OracleConnection)) Console.WriteLine("Get Customers from Oracle");

            return new List<Customer> {
                new Customer() { Id = 1, Name = "John Wick", Email = "john@wick.com", Phone = "01234" },
                new Customer() { Id = 2, Name = "Clint Eastwood", Email = "clint@eastwood.com", Phone = "56789" }
            };
        }
    }
}
