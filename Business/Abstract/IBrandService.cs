using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetById(int id);
        List<Brand> GetAll();
        public void Add(Brand brand);
        public void Delete(Brand brand);
        public void Update(Brand brand);
    }
}
