using BookShop.Core.Models;
using BookShop.Core.Other;
using System;
using System.Linq;

namespace BookShop.Core.Mappers
{
    internal static class Mappers
    {
        internal static CustomerDto CustomerToDto(this Customer customer)
        {
            return new CustomerDto() { ID = customer.Id, Name = customer.Name, Surname = customer.Surname };
        }

        internal static Record OrderToRecord(this Order order)
        {
            var customer = order.Customer;
            var employee = order.Employee;

            var record = new Record()
            {
                ID = order.Id,
                DateCreated = order.DateCreated,
                DateClosed = order.DateClosed,
                CustomerFullName = string.Join(" ", customer.Surname, customer.Name),
                EmployeeFullName = string.Join(" ", employee.Surname, employee.Name, employee.Patronymic),
                CustomerID = customer.Id,
                EmployeeID = employee.Id,
                State = (RecordState)order.OrderState
            };

            record.Items = order.OrderItem.Select(x =>
                                               new Item()
                                               {
                                                   ID = x.Id,
                                                   Name = x.Product.Product.Title,
                                                   Price = x.Product.Price,
                                                   ProductID = x.ProductId
                                               }).ToList();

            return record;
        }

        internal static Order RecordToOrder(this Record record)
        {
            return new Order()
            {
                Id = record.ID,

                OrderState = (int)record.State,
                DateCreated = record.DateCreated,
                DateClosed = record.DateClosed,
                CustomerId = record.CustomerID,
                EmployeeId = record.EmployeeID
            };
        }


        internal static User EmployeeToUser(this Employee emp)
        {
            return new User()
            {
                ID = emp.Id,
                Name = emp.Name,
                Surname = emp.Surname,
                Patronymic = emp.Patronymic,
                Birthday = DateTime.Parse(emp.Birthday),
                Email = emp.Email,
                Phone = emp.Phone,
                Photo = emp.Photo,
                UserType = (UserType)emp.UserType
            };
        }
    }
}
