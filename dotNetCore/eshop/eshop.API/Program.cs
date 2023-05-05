using eshop.API.Extension;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddIoCDetails(connectionString);
builder.Services.AddCors(option => option.AddPolicy("allow", builder =>
{
    builder.AllowAnyOrigin();
    /*
     * Farklı orjinler:
     * http://www.turkayurkmez.com
     * https://www.turkayurkmez.com
     * https://posts.turkayurkmez.com
     * https://posts.turkayurkmez.com:8080
     * 
     * Aynı Orijin:
     * http://www.turkayurkmez.com/hakkimda
     * 
     */
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();

}));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Bu cümle çok önemli")),
                        ValidIssuer = "api.halkbank.com",
                        ValidAudience = "krediler.halkbank.com",
                        ValidateIssuer = false,
                        ValidateAudience = false,

                    };
                });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("allow");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
