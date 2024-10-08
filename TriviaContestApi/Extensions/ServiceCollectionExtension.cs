﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TriviaContestApi.DataAccess;
using TriviaContestApi.DataAccess.Repositories.Category_;
using TriviaContestApi.DataAccess.Repositories.Contest_;
using TriviaContestApi.DataAccess.Repositories.ContestAward_;
using TriviaContestApi.DataAccess.Repositories.ContestRule_;
using TriviaContestApi.DataAccess.Repositories.ContestType_;
using TriviaContestApi.DataAccess.Repositories.LeaderBoard_;
using TriviaContestApi.DataAccess.Repositories.LeaderBoardTeam_;
using TriviaContestApi.DataAccess.Repositories.LeaderBoardUser_;
using TriviaContestApi.DataAccess.Repositories.Match_;
using TriviaContestApi.DataAccess.Repositories.MatchQuestion_;
using TriviaContestApi.DataAccess.Repositories.Question_;
using TriviaContestApi.Services.Category_;

namespace TriviaSecurityApi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IContestDbContext, ContestDbContext>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IContestRepository, ContestRepository>();
            services.AddTransient<IContestAwardRepository, ContestAwardRepository>();
            services.AddTransient<IContestRuleRepository, ContestRuleRepository>();
            services.AddTransient<IContestTypeRepository, ContestTypeRepository>();
            services.AddTransient<ILeaderBoardRepository, LeaderBoardRepository>();
            services.AddTransient<ILeaderBoardTeamRepository, LeaderBoardTeamRepository>();
            services.AddTransient<ILeaderBoardUserRepository, LeaderBoardUserRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();
            services.AddTransient<IMatchQuestionRepository, MatchQuestionRepository>();

            services.AddTransient<ICategoryService, CategoryService>();

        }
        public static void AddTheDbContext(this IServiceCollection services)
        {
            var dbhost = "192.168.1.105"; //Environment.GetEnvironmentVariable("DB_HOST");
            var dbname = "TriviaContestDB";// Environment.GetEnvironmentVariable("DB_NAME");
            var dbpassword = "Seda@123";// Environment.GetEnvironmentVariable("DB_SA_PASSWORD");
            services.AddDbContext<ContestDbContext>(
                       
                      options => options.UseSqlServer(@$"Data Source={dbhost};Initial Catalog={dbname};User ID=sa;Password={dbpassword};Trust Server Certificate=True;Connect Timeout=30")
                       //options => options.UseSqlServer(@$"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TriviaContestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
                   );
        }

    }
}
