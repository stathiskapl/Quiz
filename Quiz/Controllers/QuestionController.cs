using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Services;
using Microsoft.Extensions.Logging;

namespace Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _service;
        private readonly ILogger<QuestionController> _log;

        public QuestionController(IQuestionService service, ILogger<QuestionController> log)
        {
            _log = log;
            _service = service;
        }
        [HttpGet("GetAllForTestId/{testId}")]
        public async Task<IActionResult> GetAllForTestId(int testId)
        {
            try
            {

                var questions = await _service.GetAllQuestionsForTestId(testId);
                _log.LogInformation($"Returning {questions.Count} questions");
                return Ok(questions);
            }
            catch (Exception ex)
            {
                _log.LogError($"Something went wrong: {ex}");
                return StatusCode(500, ex);
            }
        }
    }
}
