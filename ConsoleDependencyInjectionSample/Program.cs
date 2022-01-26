using ConsoleDependencyInjectionSample.Repositories;
using ConsoleDependencyInjectionSample.Services;

//var customerService = new CustomerService();
//var communicationService = new CommunicationService();

var sender = new EmailService();
var connection = new OracleConnection();
var repository = new CustomerRepository(connection);

var customerService = new CustomerService(repository);
var communicationService = new CommunicationService(sender);


var customers = customerService.GetCustomers();

var message = "Message to broadcast to all customers";

foreach(var customer in customers) {
    communicationService.SendMessage(customer, message);
}