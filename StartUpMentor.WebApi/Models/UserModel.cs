using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class UserModel
    {
        //One to one relation - User has one Info
        public virtual InfoModel Info { get; set; }

        //One to many relation
        //User can be part of many fields
        public virtual ICollection<FieldModel> Fields { get; set; }
        //User can ask many questions
        public virtual ICollection<QuestionModel> Questions { get; set; }
        //If mentor - User can have many answers
        public virtual ICollection<AnswerModel> Answers { get; set; }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string salt { get; set; }

        public ICollection<RoleModel> Roles { get; set; }
    }
}