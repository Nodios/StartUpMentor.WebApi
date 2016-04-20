using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class AnswerModel
    {
        public string AnswerText { get; set; }
        public string VideoPath { get; set; }
        //User that answered question
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateLastEdited { get; set; }

        //FK for User
        public string UserId { get; set; }
        //One to many - One answer can be posted by a single user
        public virtual UserModel User { get; set; }

        //FK for Question
        public Guid QuestionId { get; set; }
        //One Answer is related to one Question
        public virtual QuestionModel Question { get; set; }
    }
}