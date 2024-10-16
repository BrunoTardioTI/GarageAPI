using GarageApi.WS.GerenciadorDeUsuarios.Repositorio;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// L� as configura��es do appsettings.json e vincula � classe MongoDBSettings
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDBSettings"));
// Injetando o contexto do MongoDB (caso necess�rio)

// Adicione sua string de conex�o aqui
const string connectionUri = "mongodb+srv://brunotardioti:160689T%40rdi0@cluster0.9lir0.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

// Criar uma inst�ncia da conex�o com o MongoDB
var mongoDbConnection = new MongoDbConnection(connectionUri);

// Testar a conex�o
mongoDbConnection.TestConnection();

builder.Services.AddControllers();
builder.Services.AddSingleton<MongoDbConnection>(sp =>
{
    return new MongoDbConnection(connectionUri);
});
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