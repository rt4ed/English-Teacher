using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net;
using TeacherEnglish;
using TeacherEnglish.Entities;
using Telegram.Bot;
using Telegram.Bot.Types;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseNpgsql(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    if (db.IrregularVerbs.Count() == 0)
    {
        var IrregularVerbsSite = new IrregularVerbsSite();
        var table = IrregularVerbsSite.GetIrregularVerbs("http://begin-english.ru/study/irregular-verbs/");
        foreach (var row in table)
        {
            var irregularVerb = new IrregularVerb();
            irregularVerb.Infinitive = row[0];
            irregularVerb.PastSimple = row[1];
            irregularVerb.PastParticiple = row[2];
            irregularVerb.Translation = row[3];
            db.IrregularVerbs.Add(irregularVerb);
            db.SaveChanges();
        }
    }
}

var client = new TelegramBotClient("5982459665:AAFhEyW6Fx0-fImk-2TU_hI91liq2cHSF-Q");
client.StartReceiving(Update, Error);
Console.ReadLine();

async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
{
    var message = update.Message;
    if (message.Text != null)
    {

    }
}

async Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
{
    throw new NotImplementedException();
}


