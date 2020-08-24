namespace TestService
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Extensions;
    using System;
    using System.Threading.Tasks;

    public class TestMiddleware
    {
        private RequestDelegate next;

        public TestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("TestMiddleware invoked.");
            if (context.Request.GetEncodedPathAndQuery().Contains("Uh-Oh", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("OH NO!");
            }

            await this.next(context);
        }
    }
}
