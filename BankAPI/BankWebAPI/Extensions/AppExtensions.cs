using TrekkoBankAPI.Middlewares;

namespace TrekkoBankAPI.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMidllerware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErroHandlerMiddleware>();
        }
    }
}
