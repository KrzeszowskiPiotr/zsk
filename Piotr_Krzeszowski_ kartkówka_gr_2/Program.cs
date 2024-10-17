using System;
using System.Collections.Generic;

// Klasa bazowa dla osoby
public class Person
{
  public string FirstName { get; set; }
  public string LastName { get; set; }

  public Person(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }
}

// Klasa reprezentująca gościa, dziedziczy po klasie Person
public class Guest : Person
{
  public Guest(string firstName, string lastName) : base(firstName, lastName)
  {

  }
}

// Klasa reprezentująca pokój
public class Room
{
  public int RoomNumber { get; set; }
  public string RoomType { get; set; }
  public decimal PricePerNight { get; set; }

  public Room(int roomNumber, string roomType, decimal pricePerNight)
  {
    RoomNumber = roomNumber;
    RoomType = roomType;
    PricePerNight = pricePerNight;
  }
}

// Klasa reprezentująca hotel
public class Hotel
{
    public List<Room> RoomList { get; set; }
    public List<Guest> GuestList { get; set; }
    public Dictionary<Guest, Room> ReservedRoomDictionary { get; set; }

    Hotel()
    {
        RoomList = new List<Room>();
        GuestList = new List<Guest>();
        ReservedRoomDictionary = new Dictionary<Guest, Room>();
    }

    public void AddRoom(Room room)
    {
        Console.WriteLine($"Dodawanie pokoju: {room.RoomNumber} {room.RoomType} {room.PricePerNight}zl");
        RoomList.Add(room);
    }
    public void DisplayRooms()
    {
        Console.WriteLine($"Lista pokoji: ");
        foreach (Room room in RoomList)
        {
            Console.WriteLine($"{room.RoomNumber} {room.RoomType} {room.PricePerNight}zl");
        }
    }
    public void AddGuest(Guest guest)
    {
        Console.WriteLine($"Dodawanie goscia: {guest.FirstName} {guest.LastName}");
        GuestList.Add(guest);
    }
    public void DisplayGuests()
    {
        Console.WriteLine($"Lista gosci: ");
        foreach (Guest guest in GuestList)
        {
            Console.WriteLine($"{guest.FirstName} {guest.LastName}");
        }
    }
    public void ReserveRoom(Guest guest, Room room)
    {
        ReservedRoomDictionary.Add(guest, room);
        Console.WriteLine($"Gość {guest.FirstName} {guest.LastName} zarezerwował pokój: {room.RoomNumber} ({room.RoomType})");
        RoomList.Remove(room);
    }
    public void DisplayReservedRooms()
    {
        Console.WriteLine("Lista zarezerwowanych pokoji: ");
        foreach (KeyValuePair<Guest, Room> RRD in ReservedRoomDictionary)
        {
            Console.WriteLine($"Gość {RRD.Key.FirstName} {RRD.Key.LastName} -- {RRD.Value.RoomNumber} {RRD.Value.RoomType} {RRD.Value.PricePerNight}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Hotel hotel = new Hotel();

            // Dodawanie pokoi
            Room room1 = new Room(101, "Jednoosobowy", 200m);
            Room room2 = new Room(102, "Dwuosobowy", 300m);
            Room room3 = new Room(103, "Apartament", 500m);
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);

            // Wyświetlanie pokoi przed rezerwacją
            hotel.DisplayRooms();
            Console.WriteLine();

            // Dodawanie gości
            Guest guest1 = new Guest("Jan", "Kowalski");
            Guest guest2 = new Guest("Anna", "Nowak");
            Guest guest3 = new Guest("Piotr", "Wiśniewski");
            hotel.AddGuest(guest1);
            hotel.AddGuest(guest2);
            hotel.AddGuest(guest3);

            // Rezerwowanie pokoi
            hotel.ReserveRoom(guest1, room1);
            hotel.ReserveRoom(guest2, room2);
            hotel.ReserveRoom(guest3, room3);
            Console.WriteLine();

            // Wyświetlanie informacji po rezerwacji
            hotel.DisplayGuests();
            Console.WriteLine();

            hotel.DisplayReservedRooms();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
