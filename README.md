# LoggingMiddlewareExample
Demonstration app showing how to add logging middleware to an ASP.NET Core application.

Some people have attempted to add logging middleware to log the response body at the end of an ASP.NET Core request, but noticed that doing so prevents the developer exception page from being displayed.

I believe this is due to wiring up the middleware in the wrong order. This small demonstration application shows one technique for doing this without interrupting the generation of the developer exception page.

Run the demonstration server and enter this URL:

http://localhost:5001/Uh-Oh

This will trigger the developer exception page, while at the same time logging the response body to the console.
