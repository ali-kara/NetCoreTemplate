using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Category;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IResult Add(CategoryAddDto categoryAddDto);
        IResult IsExists(string CategoryName);
    }
}
