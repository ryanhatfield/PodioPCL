using PodioPCL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class QuestionService.
	/// </summary>
    public class QuestionService
    {
        private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
        public QuestionService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

		/// <summary>
		/// Answers the question for the given object. The object type can be either "status" or "comment".
		/// <para>Podio API Reference: https://developers.podio.com/doc/questions/answer-question-887232 </para>
		/// </summary>
		/// <param name="questionId">The question identifier.</param>
		/// <param name="questionOptionId">The question option identifier.</param>
		/// <returns>Task.</returns>
        public Task AnswerQuestion(int questionId, int questionOptionId)
        {
            string url = string.Format("/question/{0}/", questionId);
            dynamic requestData = new
            {
                question_option_id = questionOptionId
            };
            return _podio.PostAsync<dynamic>(url, requestData);
        }

		/// <summary>
		/// Returns all the answers for the given question on the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/questions/get-answers-945753  </para>
		/// </summary>
		/// <param name="questionId">The question identifier.</param>
		/// <returns>Task&lt;List&lt;Answer&gt;&gt;.</returns>
        public Task<List<Answer>> GetAnswers(int questionId)
        {
            string url = string.Format("/question/{0}/", questionId);
            return _podio.GetAsync<List<Answer>>(url);
        }

		/// <summary>
		/// Creates a new question on the given object. Supported object types are "status" and "comment".
		/// <para>Podio API Reference: https://developers.podio.com/doc/questions/create-question-887166 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="questionText">The text of the question.</param>
		/// <param name="options">The list of text for the option</param>
		/// <returns>Task&lt;System.Int32&gt;.</returns>
        public async Task<int> CreateQuestion(string refType, int refId, string questionText, List<string> options)
        {
            string url = string.Format("/question/{0}/{1}/", refType, refId);
            dynamic requestData = new
            {
                text = questionText,
                options = options
            };
            dynamic response = await _podio.PostAsync<dynamic>(url, requestData);
            return (int)response["question_id"];
        }
    }
}
