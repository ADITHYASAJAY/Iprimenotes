﻿using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEFCodeFirst_Demo2.Repository
{
    public class MarksRepository : IRepository<Marks>
    {
        private readonly MyContext _context;
        public MarksRepository(MyContext context) 
        {  _context = context; }
        public void Add(Marks entity)
        {
            _context .Add(entity);
            _context .SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Marks Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marks> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Marks entity)
        {
            throw new NotImplementedException();
        }
    }
}
