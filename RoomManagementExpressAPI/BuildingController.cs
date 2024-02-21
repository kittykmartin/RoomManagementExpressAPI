using Microsoft.AspNetCore.Mvc;

namespace RoomManagementExpressAPI;

public class BuildingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}