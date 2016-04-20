using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class InfoModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        //FK for user
        public string UserId { get; set; }

        //One to one
        public virtual UserModel User { get; set; }
    }
}