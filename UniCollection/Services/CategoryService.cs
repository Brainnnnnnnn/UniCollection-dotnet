using UniCollection.Dtos;
using UniCollection.Models;
using UniCollection.Repositories;

namespace UniCollection.Services;

public class CategoryService(CateoryRepository _repo)
{
    public List<Category> GetCategories()
    {
        return _repo.GetAll();
    }


    public Category GetCategoryById(int id)
    {
        return _repo.GetById(id);
    }

    public int AddCategory(CategoryDto categoryDto)
    {
        var category = new Category();
        category.Name = categoryDto.Name;
        _repo.Add(category);
        return category.Id;
    }

    public int DeleteCategoryById(int id)
    {
        return _repo.DeleteById(id);
    }
}