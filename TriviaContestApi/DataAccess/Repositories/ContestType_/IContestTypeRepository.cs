﻿using TriviaContestApi.DataAccess.Entities;

namespace TriviaContestApi.DataAccess.Repositories.ContestType_
{
    public interface IContestTypeRepository
    {
        Task<List<ContestType>> GetAll();
        Task<ContestType> GetById(int id);
        Task<bool> Update(ContestType ctype);
        Task<int> Add(ContestType ctype);
    }
}
