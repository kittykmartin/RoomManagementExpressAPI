namespace RoomManagementExpressAPI.Buildings;

public class Building
{
    public Building(string buildingName)
    {
        this.BuildingName = buildingName;
    }

    public string BuildingName { get; set; }
}