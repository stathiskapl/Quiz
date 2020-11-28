using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Models;
using Quiz.Repositories;

namespace Quiz.Services
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAllQuestionsForTestId(int testId);
    }

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _repository;

        public QuestionService (IQuestionRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Question>> GetAllQuestionsForTestId(int testId)
        {
            return await _repository.GetAllQuestionsForTestId(testId);
        }
    }
}
