using System.ComponentModel.DataAnnotations;

namespace AppMovie.Models
{
    public class User
    {

            public int Id { get; set; }
            public string? Name { get; set; }
            public int  SeatNumber { get; set; }
            public int  RoomNumber { get; set; }

    }
}
