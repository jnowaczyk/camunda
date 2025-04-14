using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using CamundaApi;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.MapPost("/reservation", (HttpResponse response, OrderRequest orderData) =>
{
    var available = Stock.IsAvailable(orderData.Items);
    response.ContentType = "application/json; charset=utf-8";
   
    var result = new
    {
        CanBeReserved = available,
        TimeStamp = DateTime.UtcNow,
        CaseId = available ? Guid.NewGuid().ToString() : string.Empty
    };

    return Results.Ok(result);
})
.WithName("reservation")
.WithOpenApi();


app.MapGet("/orders", () => 
{
    

    return new { Orders = new[]
    {
        new{ OrderNumber = "ABC3"}
    }};
}) 
.WithName("Orders")
.WithOpenApi();


app.Run();

public record StockItem(ItemType Type, int Quantity);

record OrderRequest(IEnumerable<StockItem> Items);

public enum ItemType 
{
    Mouse = 1,
    Keyboard
}