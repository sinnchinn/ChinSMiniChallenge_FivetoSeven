using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge5;
using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge6;
using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_1;
using ChinSMiniChallenge_FivetoSeven.Services.MiniChallenge7_2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniCh5Service, MiniCh5Service>();
builder.Services.AddScoped<IMiniCh6Service, MiniCh6Service>();
builder.Services.AddScoped<IMiniCh7_1Service, MiniCh7_1Service>();
builder.Services.AddScoped<IMiniCh7_2Service, MiniCh7_2Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
