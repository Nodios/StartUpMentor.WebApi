﻿using StartUpMentor.Common.Filters;
using StartUpMentor.Model.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StartUpMentor.Service.Common
{
	public interface IQuestionService
    {
        Task<IQuestion> GetAsync(Guid id);
        Task<IEnumerable<IQuestion>> GetRangeAsync(Guid fieldId, GenericFilter filter);
        Task<int> AddAsync(IQuestion question);
        Task<int> UpdateAsync(IQuestion question);
        Task<int> DeleteAsync(IQuestion question);
        Task<int> DeleteAsync(Guid id);
    }
}
