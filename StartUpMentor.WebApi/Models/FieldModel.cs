using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class FieldModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        //Field can have many users - must define UserField table
        public virtual ICollection<UserModel> Users { get; set; }
        //Field can contain many questions
        public virtual ICollection<QuestionModel> Questions { get; set; }
    }
}