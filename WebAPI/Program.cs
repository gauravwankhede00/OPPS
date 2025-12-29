using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Threading.RateLimiting;
using WebAPI;
using WebAPI.Middleware;
using WebAPI.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(WebAPI.Repository.IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<StockDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});


builder.Services.AddControllers()
            .AddXmlSerializerFormatters(); // Add support for XML



builder.Services.AddRateLimiter(rateLimiterOptions =>
{
    rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

    //rateLimiterOptions.AddFixedWindowLimiter("fixed", options =>
    //{
    //    options.Window = TimeSpan.FromSeconds(10);
    //    options.PermitLimit = 3;
    //    options.QueueLimit = 3;
    //    options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
    //});

    rateLimiterOptions.AddSlidingWindowLimiter("sliding", options =>
    {
        options.Window = TimeSpan.FromSeconds(15);
        options.SegmentsPerWindow = 2;
        options.PermitLimit = 3;
    });
});

builder.Services.AddCors((ser) =>
{
    ser.AddPolicy("EnableCors", policy =>
    {

        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});

builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "X-CSRF-TOKEN";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    var antiForgery = context.RequestServices.GetService<IAntiforgery>();
    var tokens = antiForgery.GetAndStoreTokens(context);
    context.Response.Cookies.Append("X-CSRF-TOKEN", tokens.RequestToken!,
        new CookieOptions { HttpOnly = false,
            Secure = true,
            SameSite = SameSiteMode.None
        });

    await next();
});

app.Use((context, next) =>
{

    if (context.User.Identity?.IsAuthenticated ?? false)
    {
        //context.Response.Body.a
    }
    return next.Invoke();

});
app.UseHttpsRedirection();
app.UseCors("EnableCors");
app.UseRateLimiter();
app.UseAuthorization();
app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();

app.Run();
