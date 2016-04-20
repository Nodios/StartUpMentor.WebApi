using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartUpMentor.WebApi.Models
{
    public class RoleModel
    {
        public Guid Id { get; set; }
        public string roleName { get; set; }
        public ICollection<UserModel> Users { get; set; }
    }
}