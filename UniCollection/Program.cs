using SqlSugar;
using UniCollection.Models;
using UniCollection.Repositories;
using UniCollection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 注册 SqlSugar
builder.Services.AddSingleton<ISqlSugarClient>(sp =>
{
    var db = new SqlSugarClient(new ConnectionConfig()
    {
        ConnectionString = builder.Configuration.GetConnectionString("MySQLConn"),
        DbType = DbType.MySql,
        IsAutoCloseConnection = true,
        InitKeyType = InitKeyType.Attribute
    });

    // 自动建表（根据实体类）
    db.CodeFirst.InitTables(typeof(Category), typeof(Resource)); 

    return db;
});


// Category系列
builder.Services.AddScoped<CateoryRepository>();
builder.Services.AddScoped<CategoryService>();


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