using FaceApi.DB;
using FaceApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers() .AddNewtonsoftJson(options =>
{
    options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
}); // Enable MVC-style controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Face API",
        Description = "API for capturing frames and detecting faces",
    });
    options.UseInlineDefinitionsForEnums();
});

builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddDbContext<FaceDbContext>(options =>
    options.UseSqlite("Data Source=databases/FaceDatabase.db"));

// Register the face detection service
builder.Services.AddScoped<IUsbCameraService, UsbCameraService>();
builder.Services.AddScoped<IFileImageService, FileImageService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IMetadataService, MetadataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Camera API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<FaceDbContext>();
    dbContext.Database.EnsureCreated(); // Create database if not exists
}

app.MapControllers(); // Map attribute-based controllers

app.Run();