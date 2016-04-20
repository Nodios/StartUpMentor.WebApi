﻿using System;
using System.Collections.Generic;
using StartUpMentor.Model.Common;

namespace StartUpMentor.Model
{
	public class Field : IField
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        //Field can have many users - must define UserField table
        public virtual ICollection<IUser> Users { get; set; }
        //Field can contain many questions
        public virtual ICollection<IQuestion> Questions { get; set; }
    }
}
