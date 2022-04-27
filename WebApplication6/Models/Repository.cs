using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }

        }

        public static void AddResponce(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
 