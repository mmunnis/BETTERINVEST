﻿using BETTERINVEST.SHARED;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BETTERINVEST.DATA.Contracts
{
    public interface IArticleManager
    {
        Task<int> Create(Article article);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Article article);
        Task<Article> GetById(int Id);
        Task<List<Article>> ListAll(int skip, int take, string orderBy, string direction, string search);
    }
}
