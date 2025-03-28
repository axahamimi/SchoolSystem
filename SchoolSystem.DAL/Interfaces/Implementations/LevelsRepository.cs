﻿using Microsoft.EntityFrameworkCore;
using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Entites;
using SchoolSystem.DAL.Interfaces.Abstracts;
using SchoolSystem.DAL.Interfaces.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Interfaces.Implementations
{
    public class LevelsRepository : BaseRepository<Level>, ILevelsRepository
    {
        public LevelsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Level>> GetByDepartmentId(int id)
        {
            return await _context.Levels.Where( l => l.DepartmentId == id).ToListAsync();  
        }
    }
}
