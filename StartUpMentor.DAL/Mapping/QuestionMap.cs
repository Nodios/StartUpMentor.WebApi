﻿using StartUpMentor.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StartUpMentor.DAL.Mapping
{
	public class QuestionMap : EntityTypeConfiguration<QuestionEntity>
    {
        public QuestionMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Title).IsRequired();
            Property(t => t.QuestionText).IsRequired();
            Property(t => t.VideoPath).IsRequired();
            Property(t => t.UserName).IsRequired();
            Property(t => t.Date).HasColumnType("datetime2");

            HasRequired(q => q.Field).WithMany(f => f.Questions).HasForeignKey(q => q.FieldId);
            //HasRequired(q => q.User).WithMany(u => u.Questions).HasForeignKey(q => q.UserId);
        }
    }
}
