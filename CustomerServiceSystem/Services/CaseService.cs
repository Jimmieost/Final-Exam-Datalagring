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
                //Status = addCase.Status,    
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
                    CustomerId = _case.CustomerId,
                    
                    
                });
            return _cases;
        }

        public static async Task<Case> GetAsync(int customerId)
        {
            var _case = await _context.Cases.Include(x => x.Customer).FirstOrDefaultAsync(x => x.CustomerId == customerId);
            if (_case != null)
                return new Case
                {
                    Id = _case.Id,
                    Description = _case.Description,
                    Title = _case.Title,
                    Status = _case.Status,
                    Comment = _case.Comment,
                    CustomerId = _case.CustomerId,


                };
            else
                return null!;
        }

        public async Task<CaseEntity> UpdateCaseStatusAsync(int caseId, string newStatus)
        {
            var caseEntity = await _context.Cases.FindAsync(caseId);

            if (caseEntity == null)
            {
                throw new ArgumentException($"Could not find case with ID {caseId}");
            }

            caseEntity.Status = newStatus;

            await _context.SaveChangesAsync();

            return caseEntity;
        }

        

        //public static async Task<Case> UpdateCaseStatusAsync(int caseId, string newStatus)
        //{
        //    var _case = await GetAsync(caseId);

        //    if (_case == null)

        //    {
        //        throw new ArgumentException($" Kunde inte hitta ett med ärendenummer {caseId}");


        //    };

        //    _case.Status = newStatus;

        //    await _context.SaveChangesAsync();

        //    return _case;

        //}





    }


}
