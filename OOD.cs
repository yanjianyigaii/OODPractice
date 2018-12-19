namespace HotelBooking
{
  Class Hotel{
    int id;
    List<Room> rooms;
    Criteria c;
    void GetRooms();
    bool available;
  }
  Class Room{
    Hotel hotel;
    int id;
    ?List<Date> availables;
    List<Customer> customers;
    bool Add(Customer customer);
  }
  Class Customer{
    int id;
    Date checkin;
    Date checkout;
    Room room;
  }
  Class Booking{
    int customerId;
    List<Hotel> Search(Criteria c);
    bool Book(Customer customer);
  }
  Class Criteria{
    //for encapsulate searchable hotel properties
    string name;
    string city;
    bool match();
  }
}
