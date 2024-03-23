using OdevGrup1.Application;
using OdevGrup1.Persistence;

var builder = WebApplication.CreateBuilder(args);



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
