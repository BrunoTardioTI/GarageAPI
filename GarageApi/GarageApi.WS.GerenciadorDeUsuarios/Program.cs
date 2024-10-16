using GarageApi.WS.GerenciadorDeUsuarios.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Registra as configurações do MongoDB
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDBSettings"));

// Registra o MongoDbContext
builder.Services.AddSingleton<MongoDbContext>();

// Adicionando o MongoDbContext ao projeto

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
