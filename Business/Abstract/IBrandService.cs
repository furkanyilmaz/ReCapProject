using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetCarsByBrandId(int brandId);

        List<Brand> Add();
        List<Brand> Delete();
        List<Brand> Update();
    }
}
