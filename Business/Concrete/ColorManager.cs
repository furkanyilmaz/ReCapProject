using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> Add()
        {
            throw new NotImplementedException();
        }

        public List<Color> Delete()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsColorId()
        {
            throw new NotImplementedException();
        }

        public List<Color> Update()
        {
            throw new NotImplementedException();
        }
    }
}
