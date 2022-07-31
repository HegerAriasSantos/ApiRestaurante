using Microsoft.AspNetCore.Builder;

namespace ApiRestaurante.Presentation.WebApi.Extensions
{
    public static class AppExtension
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Restaurant Api");
            });
        }
    }
}
