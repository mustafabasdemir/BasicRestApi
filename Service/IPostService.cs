using System.Collections.Generic;
using RestApi.Models;

namespace RestApi.Service
{
    public interface IPostService
    {
        Posts Create(Posts posts);
        Posts Update(int id,Posts posts);
        Posts GetPosts(int id);
        List<Posts> GetAll();
        Posts Delete(int id);

    }
}