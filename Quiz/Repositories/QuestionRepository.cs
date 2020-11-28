using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.Repositories
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetAllQuestionsForTestId(int testId);
    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Question>> GetAllQuestionsForTestId(int testId)
        {
            return await _context.Questions.Include(q=>q.Test).ThenInclude(t=>t.Lesson).ThenInclude(l=>l.Section).ThenInclude(l=>l.Class).ThenInclude(c=>c.School).Where(q => q.Test.Id == testId).ToListAsync();
        }
    }
}
