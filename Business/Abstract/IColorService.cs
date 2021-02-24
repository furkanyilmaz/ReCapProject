using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetCarsColorId();
        List<Color> Add();
        List<Color> Delete();
        List<Color> Update();
    }
}
