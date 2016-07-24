using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Trello.Assignment
{
    public static class AssignHandler
    {
        public static async Task Get(HttpContext context)
        {
            await context.Response.SendFileAsync("Trello.Assignment/assign.html");
        }

        public static async Task Post(HttpContext context)
        {
            var id = context.GetRouteValue("id");
            await context.Response.WriteAsync($"Hello, {id}!");
        }
    }
}
