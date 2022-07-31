using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetById(int id);
        List<Color> GetAll();
        public void Add(Color color);
        public void Delete(Color color);
        public void Update(Color color);
    }
}
