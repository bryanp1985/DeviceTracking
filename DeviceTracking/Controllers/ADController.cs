using System.Collections.Generic;
using System.Web.Http;

namespace DeviceTracking.Controllers
{
    public class ADController : ApiController
    {
        // GET: api/AD
        public IEnumerable<string> GetAD(string username)
        {
            AD adCall = new AD();
            string[] results = new string[2];
            var searcher = adCall.GetDirectorySearcher("OU = CriticalMass, DC = cmass, DC = criticalmass, DC = com", "", "");
            var searchResult = adCall.SearchUserByUserName(searcher, username);
            if (searchResult.GetDirectoryEntry().Properties["mail"].Value != null)
                        results[0] = "Email ID : " + searchResult.GetDirectoryEntry().Properties["mail"].Value.ToString();
            if (searchResult.GetDirectoryEntry().Properties["givenName"].Value != null)
                        results[1] = "First Name : " + searchResult.GetDirectoryEntry().Properties["givenName"].Value.ToString();
                return results;
        }

        // GET: api/AD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AD
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AD/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AD/5
        public void Delete(int id)
        {
        }
    }
}
