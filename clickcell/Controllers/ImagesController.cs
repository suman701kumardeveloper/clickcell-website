using System.Collections.Generic;
using System.Web.Http;

namespace clickcell.Controllers
{
    public class ImagesController : ApiController
    {
        //Use PUT when you can update a resource completely through a specific resource. For instance, 
        //if you know that an article resides at http://example.org/article/1234, you can PUT a new resource representation of this article directly through a PUT on this URL.
        //If you do not know the actual resource location, for instance, when you add a new article, but do not have any idea where to store it,
        //you can POST it to an URL, and let the server decide the actual URL.
        //- See more at: http://restcookbook.com/HTTP%20Methods/put-vs-post/#sthash.kkHaAmrh.dpuf

        // GET api/images
        //if you do a get request to root + api/images it will hit this method and return wahtever the method returns if you say you want xml it will return xml if you say json you get json
        // www.clickcell.co.uk/api/images
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/images/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/images
        public void Post([FromBody]string value)
        {
        }

        // PUT api/images/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/images/5
        public void Delete(int id)
        {
        }
    }
}
