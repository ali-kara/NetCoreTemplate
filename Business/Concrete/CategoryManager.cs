using System;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Entities.DTOs.Category;
using Entities.Constants;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public IResult Add(CategoryAddDto categoryAddDto)
        {
            Category category = new Category
            {
                CategoryName = categoryAddDto.CategoryName,
                Description = categoryAddDto.Description,
            };

            categoryDal.Add(category);


            return new SuccessResult(Messages.CategoryCreated);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new DataResult<List<Category>>(categoryDal.GetAll(), true);
        }

        public IResult IsExists(string CategoryName)
        {

            if (categoryDal.Get(x=>x.CategoryName == CategoryName) != null)
            {
                return new ErrorResult(Messages.CategoryAlreadyExists);
            }

            return new SuccessResult();
        }

    }
}