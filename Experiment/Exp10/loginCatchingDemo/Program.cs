var builder = WebApplication.CreateBuilder(args);

// ✅ Services
builder.Services.AddControllers();
builder.Services.AddMemoryCache();

var app = builder.Build();

// ✅ Middleware
app.UseHttpsRedirection();

// ✅ Controller mapping (MOST IMPORTANT)
app.MapControllers();

app.Run();