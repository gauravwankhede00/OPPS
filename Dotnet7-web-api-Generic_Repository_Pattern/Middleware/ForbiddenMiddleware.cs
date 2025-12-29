namespace GenericRepository_JWT.Middleware
{
    public class ForbiddenMiddleware
    {
        private readonly RequestDelegate _next;
        public ForbiddenMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Let the request proceed through the pipeline
            await _next(context);

            // Check if the response is 403 Forbidden
            if (context.Response.StatusCode == StatusCodes.Status403Forbidden)
            {
                // Customize the response
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(new
                {
                    StatusCode = 403,
                    Message = "Access denied. You do not have the required role."
                });
            }
        }

    }
}
