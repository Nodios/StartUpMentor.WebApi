using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using StartUpMentor.WebApi.Models;
using StartUpMentor.Model.Common;
using StartUpMentor.Model;

namespace StartUpMentor.WebApi.App_Start.AutoMapperApiLayerMapping
{
    public class Mappingconfiguration : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AnswerModel, IAnswer>().ReverseMap();
            Mapper.CreateMap<AnswerModel, Answer>().ReverseMap();
            Mapper.CreateMap<Answer, IAnswer>().ReverseMap();

            Mapper.CreateMap<FieldModel, IField>().ReverseMap(); 
            Mapper.CreateMap<FieldModel, Field>().ReverseMap();
            Mapper.CreateMap<Field, IField>().ReverseMap();

            Mapper.CreateMap<InfoModel, IInfo>().ReverseMap();
            Mapper.CreateMap<InfoModel, Info>().ReverseMap();
            Mapper.CreateMap<Info, IInfo>().ReverseMap();

            Mapper.CreateMap<QuestionModel, IQuestion>().ReverseMap();
            Mapper.CreateMap<QuestionModel, Question>().ReverseMap();
            Mapper.CreateMap<Question, IQuestion>().ReverseMap();

            Mapper.CreateMap<UserModel, IUser>().ReverseMap();
            Mapper.CreateMap<UserModel, User>().ReverseMap();
            Mapper.CreateMap<User, IUser>().ReverseMap();

            //Mapper.CreateMap<ISecurityEntity, TokenEntity>();
            //Mapper.CreateMap<TokenEntity, ISecurityEntity>();

            //Mapper.CreateMap<IRole, RoleEntity>();
            //Mapper.CreateMap<IRole, RoleEntity>().ReverseMap();

            //Mapper.CreateMap<IRole, string>().ConvertUsing(source => source.roleName ?? string.Empty);
            //Mapper.CreateMap<ICollection<Role>, ICollection<string>>();
        }
    }
}