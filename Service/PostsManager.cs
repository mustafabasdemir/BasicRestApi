using System.Collections.Generic;
using RestApi.Models;
using RestApi.Repository;

namespace RestApi.Service
{
    public class PostsManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;
        public PostsManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }
        public Posts Create(Posts posts)
        {
            // bir sürü işlem olabilir  


            /*
                burada yapılan su  : aslında  yazdıgımız generic repository içine pots
                modelini gonderiyoruz o gonderien modele ekleme işlemi yapacak 
            */
            return _repository.Add(posts);
        }

        public Posts Delete(int id)
        {
            var deletePosts = _repository.GetById(id);
            return _repository.Delete(deletePosts);
        }


        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }


        public Posts GetPosts(int id)
        { 
            //buraya dolu ise sunu bunu yap vs eklenebilir 
            return _repository.GetById(id);
        }

        public Posts Update(int id, Posts posts)
        {
           return _repository.UpdateById(posts,id);
        }

    }
}