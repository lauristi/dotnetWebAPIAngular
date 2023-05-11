namespace webapi.Middleware.CorsPolicy
{
    //----------------------------------------------------------------------------------
    // Extension method used to add the middleware to the HTTP request pipeline.
    // and used it this way in the startup.cs
    //         app.UseCorsMiddleware();
    //----------------------------------------------------------------------------------

    public static class CorsMiddlewareExtensions
    {
        public static IApplicationBuilder UseCorsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CorsMiddleware>();
        }
    }
}