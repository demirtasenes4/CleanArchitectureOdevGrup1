using OdevGrup1.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(plc =>
    {
        plc.AllowAnyHeader();
        plc.AllowAnyMethod();
        plc.AllowAnyOrigin();
        plc.SetIsOriginAllowed(plc => true);
    });
});

builder.Services.AddPresentation(builder.Configuration);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();