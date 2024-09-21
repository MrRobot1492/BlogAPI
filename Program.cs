//1.Host Creation
var builder = WebApplication.CreateBuilder(args);

//2.Service Registration
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//3.Middleware Setup
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//4.Run application
app.Run();

//NOTE: The appsettings.json us loadede here during host creation
//Configuration values from appsettings.json can be injected into
//services and used to configure different parts of the application
//Database, connections, feature toggles, etc.