using OdevGrup1.Application;
using OdevGrup1.Persistence;
using OdevGrup1.WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(policy =>
    {
        policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .SetIsOriginAllowed(policy => true);
    });
});

builder.Services.AddApplication();
builder.Services.AddPersistance(builder.Configuration);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

ExtensionsMiddleware.CreateFirstUserAsync(app);

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); ;

app.Run();
