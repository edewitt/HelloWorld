using HelloWorldDAL.HelloWorldRepositories;
using HelloWorldModel.HelloWorldModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/hello
        public IEnumerable<HelloModel> Get()
        {

            var repo = new HelloWorldRepository();
            var hello = repo.GetAllHelloWorld();

            return hello;

        }

        // GET api/hello/5
        public HelloModel Get(int id)
        {

            var repo = new HelloWorldRepository();
            var rvalue = repo.GetHelloWorldById(id);
            
            return rvalue;

        }

        // POST api/hello
        public void Post([FromBody]string value)
        {
            // this is a change
            var repo = new HelloWorldRepository();
            repo.Insert_HelloWorld(value);

        }

        // PUT api/hello/5
        public void Put(int id, [FromBody]string value)
        {

            var repo = new HelloWorldRepository();
            var hello = new HelloModel() { Id = id, Message = value };

            repo.UpdateHelloWorld(hello);

        }

        // DELETE api/hello/5
        public void Delete(int id)
        {
            //making change
            var repo = new HelloWorldRepository();
            repo.DeleteHelloWorldById(id);

        }
    }
}
