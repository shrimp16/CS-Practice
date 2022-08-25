class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Chovy");
        Person person2 = new Person("Humanoid");

        Person person3 = new Person("Ruler");
        Person person4 = new Person("Upset");

        House house = new House();

        Room room = house.createRoom();
        room.enterRoom(person1);
        room.enterRoom(person2);

        Room room2 = house.createRoom();
        room2.enterRoom(person3);
        room2.enterRoom(person4);

        house.seeRooms();

        int roomId;

        Int32.TryParse(Console.ReadLine(), out roomId);

        Console.WriteLine(roomId);

        Room? findRoom = house.rooms.FirstOrDefault(o => o.roomId == roomId);

        if (findRoom == null)
        {
            Console.WriteLine("Seems like that room does not exist, want to create a new one?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");

            if (Console.ReadLine() == "1")
            {
                findRoom = house.createRoom();
                findRoom.enterRoom(new Person("Shrimp"));
                house.seeRooms();
                return;
            }
            return;
        }

        findRoom.enterRoom(new Person("Shrimp"));

        house.seeRooms();



    }

}

class House
{
    public List<Room> rooms { get; }

    public House()
    {
        rooms = new List<Room>();
    }

    public Room createRoom()
    {
        Room newRoom = new Room();
        rooms.Add(newRoom);
        return newRoom;
    }

    public void seeRooms()
    {
        foreach (Room room in rooms)
        {
            Console.WriteLine(room.roomId);
            Console.WriteLine("----------------------------------");
            foreach (Person person in room.persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("----------------------------------");
        }
    }

}

class Room
{

    public List<Person> persons { get; }

    public int roomId { get; }

    public Room()
    {
        persons = new List<Person>();
        roomId = new Random().Next();
    }

    public void enterRoom(Person person)
    {
        persons.Add(person);
    }

}

class Person
{

    public string name { get; private set; }

    public Person(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return $"Hello, I'm {this.name}!";
    }


}
