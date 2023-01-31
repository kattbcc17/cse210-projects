    public class promptGenerator{

    public List<string> _promptPool = new List<string>(){

        // List of prompts
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?", 

    };

    // Store the index of the prommpt given by the user
    public int _promptIndex;


    // Create a method to select a random number or iterate through a list.
    public int indexPrompt(){
        Random randomGenerator = new Random();
        _promptIndex = randomGenerator.Next(1, _promptPool.Count);
        return _promptIndex;

    }

    // Display the prompt from the list created before
    public void Display(int _promptIndex){
        Console.WriteLine(_promptPool[_promptIndex]);
    }



        
}

