using Microsoft.AspNetCore.Mvc;
using RestApi.Models;
using RestApi.Service;

namespace RestApi.Controllers
{
    [Route("api/posts")]  //apiyi cagirirken belirleyeceğiz 
    [ApiController]
    public class PostsController:ControllerBase
    {

        //servis katmanımızdaki servisi burada çağıralim
        private readonly IPostService _postservice;

        public PostsController (IPostService postservice)
        {
            _postservice = postservice;
        }

        [HttpPost]
        public ActionResult Create(Posts posts)
        {
            var response = _postservice.Create(posts);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var response = _postservice.GetPosts(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _postservice.GetAll();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var response = _postservice.Delete(id);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePosts(int id , Posts posts)
        {
            var response =  _postservice.Update(id,posts);
            return Ok(response);
        }
        
    }
}