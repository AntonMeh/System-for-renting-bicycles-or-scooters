namespace CourseWork.DTOs
{
    public class StartRentalRequest
    {
        public int ClientId { get; set; }
        public int VehicleId { get; set; }
    }

    public class EndRentalRequest
    {
        public double EndLatitude { get; set; }
        public double EndLongitude { get; set; }
    }

    public class RentalResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int? RentalId { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
