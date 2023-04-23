using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TeacherEnglish;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseNpgsql(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    
}