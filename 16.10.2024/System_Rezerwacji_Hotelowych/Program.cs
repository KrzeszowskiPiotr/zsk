namespace System_Rezerwacji_Hotelowych
{
    public class Guest
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public Guest(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public int PrizePerNight {  get; set; }

        public Room(int roomNumber, string type, int prizePerNighr)
        {
            RoomNumber = roomNumber;
            Type = type;
            PrizePerNight = prizePerNighr;
        }
    }
    public class Hotel
    {
        List<Room> RoomList { get; set; }
        List<Guest> GuestList { get; set; } 
        Dictionary <Guest, Room> ReservedRooms { get; set; }

        public Hotel()
        {
            RoomList = new List<Room>();
            GuestList = new List<Guest>();
            ReservedRooms = new Dictionary<Guest, Room>();
        }

        public void AddRoom(Room room)
        {
            Console.WriteLine($"Dodawanie pokoju nr {room.RoomNumber}, {room.Type}, {room.PrizePerNight}");
            RoomList.Add(room);
        }

        public void AddGuest(Guest guest)
        {
            Console.WriteLine($"Dodawanie gościa {guest.FirstName} {guest.LastName}");
            GuestList.Add(guest);
        }

        public void AddReservedRoom(Guest guest,Room room)
        {
            RoomList.Remove(room);
            ReservedRooms.Add(guest, room);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             Zadanie: System Rezerwacji Hotelowych
Cel:
Stwórz aplikację konsolową w języku C#, która symuluje prosty system rezerwacji hotelowych. Aplikacja powinna umożliwiać dodawanie pokoi, gości oraz rezerwowanie pokoi.

Wymagania:
Dodawanie pokoi:

Użytkownik powinien mieć możliwość dodania nowego pokoju do systemu.

Każdy pokój powinien mieć numer, typ (np. jednoosobowy, dwuosobowy) oraz cenę za noc.

Dodawanie gości:

Użytkownik powinien mieć możliwość dodania nowego gościa do systemu.

Każdy gość powinien mieć imię i nazwisko.

Rezerwowanie pokoi:

Użytkownik powinien mieć możliwość rezerwacji pokoju przez gościa.

Po rezerwacji pokój powinien być usunięty z listy dostępnych pokoi w hotelu.

Wyświetlanie informacji:

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich pokoi w hotelu.

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich gości w hotelu.

Użytkownik powinien mieć możliwość wyświetlenia listy wszystkich zarezerwowanych pokoi. */
        }
    }
}
