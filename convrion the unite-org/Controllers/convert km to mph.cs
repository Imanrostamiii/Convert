using Microsoft.AspNetCore.Mvc;

namespace convrion_the_unite_org.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class convert_km_to_mph:ControllerBase
{
    [HttpGet]
    public double km(double numbers)
    {
        double num =  numbers* 0.6213712;

        return num;
    }
}