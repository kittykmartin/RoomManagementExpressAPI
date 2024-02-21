namespace RoomManagementExpressAPI.Buildings
{
    public class BuildingsModule:IModule
    {
        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            return builder;
        }

        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/Buildings", () => new List<Building>()
                {
                    new Building("test building 1")
                })
                .WithDescription("returns list of registered buildings ")
                .WithName("GetRegisteredBuildings")
                .WithOpenApi();
            return endpoints;
        }
    }
}