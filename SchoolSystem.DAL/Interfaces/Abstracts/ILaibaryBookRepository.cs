﻿using SchoolSystem.DAL.Entites;
using SchoolSystem.DAL.Interfaces.BaseRepository;

namespace SchoolSystem.DAL.Interfaces.Abstracts
{
    public interface ILaibaryBookRepository : IBaseRepository<LaibaryBook>
    {
        Task<IEnumerable <LaibaryBook>> GetBySectionId(int id);
    }


}
