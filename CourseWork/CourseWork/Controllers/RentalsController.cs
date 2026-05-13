using CourseWork.DTOs;
using CourseWork.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalsController : ControllerBase
    {
        private readonly RentalService _rentalService;

        public RentalsController(RentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("start")]
        public async Task<IActionResult> StartRental([FromBody] StartRentalRequest request)
        {
            var result = await _rentalService.StartRentalAsync(request.ClientId, request.VehicleId);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("{rentalId}/end")]
        public async Task<IActionResult> EndRental(int rentalId, [FromBody] EndRentalRequest request)
        {
            var result = await _rentalService.EndRentalAsync(rentalId, request.EndLatitude, request.EndLongitude);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
