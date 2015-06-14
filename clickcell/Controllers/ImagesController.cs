using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using clickcell.Models;

namespace clickcell.Controllers
{
    public class ImagesController : ApiController
    {
        //Use PUT when you can update a resource completely through a specific resource. For instance, 
        //if you know that an article resides at http://example.org/article/1234, you can PUT a new resource representation of this article directly through a PUT on this URL.
        //If you do not know the actual resource location, for instance, when you add a new article, but do not have any idea where to store it,
        //you can POST it to an URL, and let the server decide the actual URL.
        //- See more at: http://restcookbook.com/HTTP%20Methods/put-vs-post/#sthash.kkHaAmrh.dpuf

        public Image TestImageGenerator(int index)
        {
            return new Image
            {
                ID = index,
                ViewCount = 0,
                FullViewCount = 0,
                HideCount = 0,
                Title = "Test Image",
                URI = String.Format("images/testimage{0}.jpg", index),
                FullViewURI = "",
                ReleaseDate = DateTime.Today,
                CategoryIDs = new List<int>()
            };
        }

        // GET api/images
        //if you do a get request to root + api/images it will hit this method and return wahtever the method returns if you say you want xml it will return xml if you say json you get json
        // www.clickcell.co.uk/api/images
        public IEnumerable<Image> Get()
        {

            // if client has a GUUID, then session is in progress
            // give them one random image that they haven't seen already
            if (HttpContext.Current.Request.Headers.GetValues("SessionID") != null)
            {
                int count = Convert.ToInt32(HttpContext.Current.Request.Headers.GetValues("count")[0]);

                if (count > 4){
                    var r = new Random();
                    return new[] { TestImageGenerator(r.Next(8))};    
                }
                else
                    return new[] { TestImageGenerator(4+count) };    
            }

            // if client doesnt have a GUID for their session, 
            // give them one and return 8 random images to kick off the session
            HttpContext.Current.Response.AppendHeader("SessionID", Guid.NewGuid().ToString());

            return new[] { TestImageGenerator(1), TestImageGenerator(2), TestImageGenerator(3), TestImageGenerator(4), };
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
