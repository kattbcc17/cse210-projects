public class Room
{
    public int _numberTables = "";
    public int _numberSeats = "";

    // special method, called a constructor that is invoked using 
    // the new keyboard followed by the class and parentheses.
    public Room()
    {
    }
    
    // Displays the person's full 
    public void  ShowNumber ()
    {
        Console.WriteLine($"{_numberTables}, {_numberSeats}");
    }

}