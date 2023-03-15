using CustomerServiceSystem.Models;
using CustomerServiceSystem.Models.Entities;
using CustomerServiceSystem.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CustomerServiceSystem.Services
{
    internal class CustomerService
    {
        public static DataContext _context = new DataContext();
        public static async Task SaveAsync(Customer customer)
        {
            var customerEntity = new CustomerEntity
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
            };

            var caseEntity = await _context.Cases.FirstOrDefaultAsync(x => x.Description == customer.Description);
            if (caseEntity != null)
                customerEntity.CaseId = caseEntity.Id;
            else
                customerEntity.Case = new CaseEntity
                {
                    Description = customer.Description,

                };
            
            _context.Add(customerEntity);
            await _context.SaveChangesAsync();
            
           
     
        }
        //public static async Task<IEnumerable<Customer>> GetAllAsync()
        //{

        //}

        //public static async Task<Customer> GetAsync(string email)
            
        //{
                
        //}

        //public static async Task UpdateAsync (Customer customer)
        //{

        //}


    }

    
}
