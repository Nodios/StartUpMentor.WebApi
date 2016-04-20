using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string QuestionText { get; set; }
        public string VideoPath { get; set; }
        //User that posted question
        public string UserName { get; set; }
        public DateTime Date { get; set; }

        //FK for Field
        public Guid FieldId { get; set; }
        //One to one - Question can be related to one Field
        public virtual FieldModel Field { get; set; }

        //FK for User
        public string UserId { get; set; }
        //One to one - Question is related to only one User
        public virtual UserModel User { get; set; }

        //One to many - One Question can have many Answers
        public virtual ICollection<AnswerModel> Answers { get; set; }
    }
}