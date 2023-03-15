using CustomerServiceSystem.Models;
using CustomerServiceSystem.Models.Entities;
using CustomerServiceSystem.Contexts;
using Microsoft.EntityFrameworkCore;

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

        public static async Task<IEnumerable<Case>> GetAllAsync()
        {
            var _cases = new List<Case>();

            foreach (var _case in await _context.Cases.ToListAsync())
                _cases.Add(new Case
                {
                    Id = _case.Id,
                    Description = _case.Description,
                    Title = _case.Title,
                    Status = _case.Status,
                    Comment = _case.Comment,
                    CustomerId= _case.CustomerId,
                    
                });
            return _cases;
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
