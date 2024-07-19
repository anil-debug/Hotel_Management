// Models/Customer.cs
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    // Other properties
}

// Models/Room.cs
public class Room
{
    public int Id { get; set; }
    public string Number { get; set; }
    public string Type { get; set; }
    // Other properties
}

// Models/Booking.cs
public class Booking
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    // Other properties
}
