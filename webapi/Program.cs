using webapi.Business;
using webapi.Business.Interface;
using webapi.Mapping;
using webapi.Services.BrasilAPI;
using webapi.Services.BrazilianFloraService;
using webapi.Services.Interfaces.BrasilAPI;
using webapi.Services.Interfaces.BrazilianFloraService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//-----------------------------------------------------------------------
//Servicos da aplicacao
//-----------------------------------------------------------------------

builder.Services.AddSingleton<IBrasilApiBLL, BrasilApiBLL>();
builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoService, BancoService>();

builder.Services.AddSingleton<IBrazilianFloraApiBLL, BrazilianFloraApiBLL>();
builder.Services.AddSingleton<IBrazilianFloraService, BrazilianFloraService>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));

builder.Services.AddAutoMapper(typeof(BrazilianFloraMapping));


//Habilitando o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(
    name: "AllowOrigin",
    builder => {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});




//-----------------------------------------------------------------------

var app = builder.Build();

//Habilitando o CORS ( Sempre coloque em primeiro lugar)
app.UseCors("AllowOrigin");

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