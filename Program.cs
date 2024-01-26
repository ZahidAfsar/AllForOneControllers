using AllForOneControllers.Services.SayHello;
using AllForOneControllers.Services;
using AllForOneControllers.Services.Guessit;
using AllForOneControllers.Services.Magic8Ball;
using AllForOneControllers.Services.Restaurant;
using AllForOneControllers.Services.Asking;
using AllForOneControllers.Services.Third;
using AllForOneControllers.Services.ChallengeFive;
using AllForOneControllers.Services.ChallengeSix;
using AllForOneControllers.Services.ChallengeSeven;
using AllForOneControllers.Services.ChallengeSevenInt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(option =>{
    option.AddPolicy("CorsPolicy",
        builder => {
        builder.AllowAnyHeader() // Allows any additional info sent with request (cookies)
        .AllowAnyMethod() // Allows any Httop Methods (HttpGet, HttpPut, etc)
        .AllowAnyOrigin(); // Allows any domain to access your API
        }
    );
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISayHelloService, SayHelloService>();
builder.Services.AddScoped<IGuessItService, GuessItService>();
builder.Services.AddScoped<IMagic8BallService, Magic8BallService>();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();
builder.Services.AddScoped<IFirstService, FirstService>();
builder.Services.AddScoped<ISecondService, SecondService>();
builder.Services.AddScoped<IThirdService, ThirdService>();
builder.Services.AddScoped<IChallengeFiveService, ChallengeFiveService>();
builder.Services.AddScoped<IChallengeSixService, ChallengeSixService>();
builder.Services.AddScoped<IChallengeSevenStringService, ChallengeSevenService>();
builder.Services.AddScoped<IChallengeSevenIntService, ChallengeSevenIntService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
