using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Trello.Assignment
{
    public static class IndexHandler
    {
        public static Task Get(HttpContext context)
        {
            return Task.Run(() => context.Response.Redirect("/assign"));
        }
    }
}
