using Service.C_Student;
using Service.C_Course;
using Service.C_Major;
using Service.C_Level;
using Service.C_Enrollment;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ISvCourse, SvCourse>();
builder.Services.AddScoped<ISvLevel, SvLevel>();
builder.Services.AddScoped<ISvMajor, SvMajor>();
builder.Services.AddScoped<ISvStudent, SvStudent>();
builder.Services.AddScoped<ISvEnrollment, SvEnrollment>();



builder.Services.AddControllers()
    .AddNewtonsoftJson(x =>
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Add services to the container.

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
