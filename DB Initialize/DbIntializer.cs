using ASPNET6_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET6_Template.Data
{
    public class DbInitializer : IDbInitializer
    {
        // Implement code here - Inject QuizDbContext
        private readonly InterrogationDbContext _context;
        
        public DbInitializer(InterrogationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
           // Implement code here - Default data insertion logics
           try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception ex){ }
            if (!_context.Problems.Any())
            {
                var questions = new List<Problem>()
                {
                    new Problem()
                    {
                        InterrogatorsProblem = "The first metal used by the man was",
                        Choice1 = "Iron",
                        Choice2 = "Copper",
                        Choice3 = "Aluminium",
                        Choice4 = "Gold",
                        Solution = "Copper"
                    },

                    new Problem()
                    {
                        InterrogatorsProblem = "Which of the following is a balanced fertiliser for plants ?",
                        Choice1 = "Urea",
                        Choice2 = "Ammonia sulphate",
                        Choice3 = "Nitrates",
                        Choice4 = "Compost",
                        Solution = "Compost"
                    }
                };

                _context.Problems.AddRange(questions);
                _context.SaveChanges();
            }
        }
        
    }
}
