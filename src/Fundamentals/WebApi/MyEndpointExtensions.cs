namespace WebApi;

public static class MyEndpointExtensions
{
    public static WebApplication MapCustomers(this WebApplication app)
    {
        app.MapGet("/customers", () => "Hello World!");
        app.MapGet("/customers/{id}", (int id) => "Hello World!");
        app.MapPost("/customers", () => "Hello World!");

        return app;
    }

    public static WebApplication MapOrders(this WebApplication app)
    {
        app.MapGet("/orders", () => "Hello World!");
        app.MapGet("/orders/{id}", (int id) => "Hello World!");
        app.MapPost("/orders", () => "Hello World!");

        return app;
    }

    public static WebApplication MapEntities(this WebApplication app)
    {
        app.MapCustomers();
        app.MapOrders();

        return app;
    }
}
