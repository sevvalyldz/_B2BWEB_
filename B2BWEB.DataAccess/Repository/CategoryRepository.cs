﻿using B2BWEB.DataAccess.Data;
using B2BWEB.DataAccess.Repository.IRepository;
using B2BWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BWEB.DataAccess.Repository
{

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }




        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
