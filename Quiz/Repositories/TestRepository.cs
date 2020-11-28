using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.Repositories
{
    public interface ITestRepository
    {
        Task<List<Test>> GetAllTests();
    }

    public class TestRepository : ITestRepository
    {
        private readonly DataContext _context;

        public TestRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Test>> GetAllTests()
        {
            return await _context.Tests.Include(t => t.Lesson).ToListAsync();
        }
    }
}
