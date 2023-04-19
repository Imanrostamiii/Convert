using Microsoft.AspNetCore.Mvc;

namespace conver_mph_to_km.Controllers;
[ApiController]
[Route("api/[controller],[action]")]
public class conver_MPH_to_km:ControllerBase
{
    [HttpGet]
    public double mph(double mph)
    {
        double numbers =  1.6093439799 * mph;


        return numbers;
    }
}