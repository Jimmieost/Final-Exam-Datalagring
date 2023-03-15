using CustomerServiceSystem.Models;
using CustomerServiceSystem.Models.Entities;
using CustomerServiceSystem.Contexts;


namespace CustomerServiceSystem.Services
{
    internal class CaseService
    {
        public static DataContext _context = new DataContext();
        public static async Task<CaseEntity> SaveAsync(AddCase addCase)
        {
            var _caseEntity = new CaseEntity
            {
                Title = addCase.Title,
                Description = addCase.Description,
                CustomerId = addCase.CustomerId,
                Status = addCase.Status,    
            };
            
            _context.Add(_caseEntity);
            await _context.SaveChangesAsync();
            return _caseEntity;
            
           
     
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
