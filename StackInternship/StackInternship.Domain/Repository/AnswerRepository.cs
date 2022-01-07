using StackInternship.Data.Entities;
using StackInternship.Data.Entities.Models;
using StackInternship.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace StackInternship.Domain.Repositories
{
    public class AnswerRepository : RepositoryBase
    {
        public AnswerRepository(StackInternshipDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Answer answer)
        {
            DbContext.Answers.Add(answer);

            return SaveChanges();
        }

        public ResponseResultType Edit(Answer answer, int answerId)
        {
            var edittingAnswer = DbContext.Answers.Find(answerId);
            if (edittingAnswer is null)
            {
                return ResponseResultType.NotFound;
            }

            edittingAnswer.Text = answer.Text;
            edittingAnswer.UpVote = answer.UpVote;
            edittingAnswer.DownVote = answer.DownVote;

            return SaveChanges();
        }

        public ResponseResultType Delete(int answerId)
        {
            var deletingAnswer = DbContext.Answers.Find(answerId);
            if (deletingAnswer is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Answers.Remove(deletingAnswer);

            return SaveChanges();
        }

        public ICollection<Answer> GetAll() => DbContext.Answers.ToList();
    }
}
