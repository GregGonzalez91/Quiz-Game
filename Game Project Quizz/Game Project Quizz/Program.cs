using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// Things I still want to do are to  Add a timer for each question like 20 sec.  Add Highscore. Play again option. Reprompt the user if an invalid input was given. Quit option 

namespace Game_Project_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the totally awesome and rad quiz game! Where you can pit yourself against others to achieve the highest score!!!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            

            int playerScore = 0;
            string answer, correct;
            bool tf;

            // Round 1
            Console.Clear();
            Console.WriteLine("Round one!");
            Thread.Sleep(2000);
            


            // Question 1
            Console.Clear();
            Console.WriteLine("Question 1: Who is the top selling boy band of all time?\n" +
                "A. Jackson 5 \n" +
                "B. Backstreet Boys \n" +
                "C. Boys to men \n" +
                "D. Snoop Dog \n") ;
            answer = Console.ReadLine().ToLower();
            correct = "a";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! The Jackson 5 is the top selling boy band of all time.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }  
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }


            // Question 2
            Console.Clear();
            Console.WriteLine("Question 2: Who is the top selling Female Artist of all time?\n" +
                "A. Cardi B \n" +
                "B. Brittany Spears \n" +
                "C. Mariah Carey \n" +
                "D. Madonna \n");
            answer = Console.ReadLine().ToLower();
            correct = "d";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Madonna is the top selling Female Artist of all time.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }


            // Question 3
            Console.Clear();
            Console.WriteLine("Question 3: What is the most played Beatles song?\n" +
               "A. Imagine \n" +
               "B. All I want for Christmas \n" +
               "C. Here comes the sun \n" +
               "D. Let it be \n");
            answer = Console.ReadLine().ToLower();
            correct = "c";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! The title Here comes the sun is the most played Beatles song.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }


            // Question 4
            Console.Clear();
            Console.WriteLine("Question 4: Who is the lead singer of Maroon 5?\n" +
               "A. Patrick Stump \n" +
               "B. Elon Musk \n" +
               "C. Adam Levine \n" +
               "D. Billy Joe Armstrong \n");
            answer = Console.ReadLine().ToLower();
            correct = "c";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Adam Levine is the lead singer of Maroon 5.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 5 
            Console.Clear();
            Console.WriteLine("Question 5: True or False. Is Country music more popular than Hip-Hop in the U.S.?\n");
            answer = Console.ReadLine().ToLower();
            tf = Convert.ToBoolean(answer);
            
            if (tf == false)
            {
                Console.WriteLine("\nGreat Job! Hip-Hop is more popular than Country music.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }




            // Round 2
            Console.Clear();
            Console.WriteLine("Round 2, Fight!\n" );
            Thread.Sleep(2000);

            // Question 1
            Console.WriteLine("Question 1: What is Adam Sandler's most popular movie? \n" +
               "A. Wedding Singer \n" +
               "B. 50 First Dates \n" +
               "C. Happy Gilmore \n" +
               "D. Click \n");
            answer = Console.ReadLine().ToLower();
            correct = "a";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Wedding Singer is Adam Sandler's most popular movie.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 2
            Console.Clear();
            Console.WriteLine("Question 2: Ture or False. The original Star Wars came out on May 25, 1977? \n");
            answer = Console.ReadLine().ToLower();
            tf = Convert.ToBoolean(answer);
            if (tf == true)
            {
                Console.WriteLine("\nGreat Job! May 25th, 1977 is when Start Wars A New Hope first premiered.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Quesiton 3
            Console.Clear();
            Console.WriteLine("Question 3: Who is the strongest Avenger? \n" + 
               "A. Thor \n" +
               "B. Iron Man \n" +
               "C. Hulk \n" +
               "D. Star Lord \n");
            answer = Console.ReadLine().ToLower();
            correct = "c";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! In the movie \"Thor Ragnarok\", Thor and Dr. Banner (aka Hulk) are trying to gain access to the Quin Jet to escape a planet. When voice verification is needed in order to access the jet, Thor proceedes to say Strongest Avenger to no avial. However when Dr. Banner tries he gets the response.. Welcome Strongest Avenger.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            //Question 4
            Console.Clear();
            Console.WriteLine("Question 4: How old is Morgan Freeman?\n" +
               "A. 77 \n" +
               "B. 81 \n" +
               "C. 65 \n" +
               "D. 83 \n");
            answer = Console.ReadLine().ToLower();
            correct = "d";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Yes Morgan Freeman is 83 years old.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 5
            Console.Clear();
            Console.WriteLine("Question 5: True or False. Is Betty White still alive? \n");
            answer = Console.ReadLine().ToLower();
            tf = Convert.ToBoolean(answer);
            
            if (tf == true)
            {
                Console.WriteLine("\nGreat Job! COVID did not claim Betty White in 2020. She lives on to this day and in our hearts.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }




            //Round 3
            Console.WriteLine("Round 3! Final Round");

            // Question 1
            Console.Clear();
            Console.WriteLine("Question 1: Which of the following is the shortcut to autoformat a document in VSCode? \n" +
               "A. Shift + Alt + F \n" +
               "B. Ctrl + Shift + F \n" +
               "C. Ctrl + Del \n" +
               "D. Alt + F5 \n");
            answer = Console.ReadLine().ToLower();
            correct = "a";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Shift + Alt + F will autoformat in VSCode.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 2
            Console.Clear();
            Console.WriteLine("Question 2: A type that represents a duration of time is a..? \n" +
               "A. DateTime \n" +
               "B. Timespan \n" +
               "C. Datespan \n" +
               "D. TimeDate \n");
            answer = Console.ReadLine().ToLower();
            correct = "b";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Timespan represents a duration of time.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 3
            Console.Clear();
            Console.WriteLine("Question 3: Which of the following is the correct way to create a Method? \n" +
               "A. Class MyMethod {} \n" +
               "B. MyMethod class = new MyMethod(); \n" +
               "C. Static void MyMethod() \n" +
               "D. MyMethod {get, set} \n");
            answer = Console.ReadLine().ToLower();
            correct = "c";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Static void MyMethod() is usually how it's done.");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Question 4
            Console.Clear();
            Console.WriteLine("Question 4: What does APIE stand for? \n" +
               "A. Awesome, People, Incorporate, Education \n" +
               "B. Abstraction, Polymorphism, Inheritance and Encapsulation \n" +
               "C. Apple, Pie, is, Electrifying \n" +
               "D. Abstraction, Polymorphism, Interface, Encapsulation \n");
            answer = Console.ReadLine().ToLower();
            correct = "b";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! Abstraction, Polymorphism, Inheritance, and Encapsulation form APIE");
                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }

            // Quesiton 5
            Console.Clear();
            Console.WriteLine("Question 5: How many Erros are in this block of code? \n " +
                "(namespace)Program _07_Inheritance\n" +
                "{\n" + 
                    "abstract class Person\n" +
                    "{\n" +
                        "public string FirstName { get; set; }\n" +
                        "public string LastName { (get; set;) }\n" +
                        "(string public) PhoneNumber { get; set; }\n" +
                        "public string Email { get; set; }\n" +
                    "}\n" +
                "public Person() { (})\n"+
                "public Person(string firstName, string Lastname, string phonenumber, string email)\n" +
                    "{\n" +
                        "FirstName = FirstName;\n"+
                        "LastName = Lastname;\n" +
                        "PhoneNumber = phonenumber;\n" +
                        "Email = email(;)\n" +
                    "}\n" +
                 "}\n" +

               "A. 9 \n" +
               "B. 7 \n" +
               "C. 12 \n" +
               "D. 4 \n");
            answer = Console.ReadLine().ToLower();
            correct = "d";
            if (answer == correct)
            {
                Console.WriteLine("\nGreat Job! There were 4 erros.\n" +
                    "Error 1: The namespace is missing.\n" +
                    "Error 2: string public needs to be switched to say public string" +
                    "Error 3: public Person() { was missing the closing bracket }" +
                    "Error 4: Email = email is missing the ; to initialze");

                playerScore++;
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("\nI'm sorry that's incorrect");
                Console.WriteLine("Your score: " + playerScore);
                Thread.Sleep(5000);
            }
            Console.ReadLine();                   
        }
    }
}
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // 3 Rounds of questions, easy, medium and hard rouds. Have highscore, if they don't get 3/5 of the questions they lose that round and can't move on. 

// Round 1 Music
/*Question 1: Who is the top selling boy band of all time
    A. Jackson 5 -
    B. Backstreet Boys
    C. Boys to men
    D. Snoop Dog
Question 2: Who is the top selling Female Artist of all time?
    A. Cardi B
    B. Brittany Spears
    C. Mariah Carey
    D. Madonna -
Question 3: What is the most played Beatles song?
    A. Imagine
    B. All I want for Christmas
    C. Here comes the sun -
    D. Let it be
Question 4: Who is the lead singer of Maroon 5?
    A. Patrick Stump
    B. Elon Musk
    C. Adam Levine -
    D. Billy Joe Armstrong
Question 5: Is country more popular that Hip-Hop in the U.S.?
    False

// Round 2 Movies
Question 1: Who is the strongest Avenger? 
    A. Thor
    B. Iron Man
    C. Hulk -
    D. Star Lord
Question 2: Ture or False. The original Star Wars came out on May 25, 1977?
    true
Question 3: What is Adam Sandler's most popular movie?
    A. Wedding Singer -
    B. 50 First Dates
    C. Happy Gilmore
    D. Click
Question 4: How old is Morgan Freeman?
    A. 77
    B. 81
    C. 65
    D. 83 -
Question 5: Is Betty White still alive? 
    True

// Round 3 C# questions
Question 1: Which of the following is the shortcut to autoformat the document in VSCode
    A. Shift + Alt + F -
    B. Ctrl + Shift + F
    C. Ctrl + Del
    D. Alt + F5
Question 2: A type that represents a duration of time is a..?
    A. DateTime
    B. Timespan -
    C. Datespan
    D. TimeDate
Question 3: Which of the following is a correct way to create a Method?
    A. Class MyMethod {}
    B. MyMethod class = new MyMethod();
    C. Static void MyMethod()
    D. MyMethod {get, set}
Question 4: What does APIE stand for
    A. Awesome, People, Incorporate, Education
    B. Abstraction, Polymorphism, Inheritance and Encapsulation
    C. Apple, Pie, is, Electrifying
    D. Abstraction, Polymorphism, Interface, Encapsulation
Question 5: How many Erros are in this block of code?

    (namespace)Program _07_Inheritance
    {
        abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { (get; set;) }
            (string public) PhoneNumber { get; set; }
            public string Email { get; set; }
        }
    public Person() { }
    public Person(string firstName, string Lastname, string phonenumber, string email)
        {
            FirstName = FirstName;
            LastName = Lastname;
            PhoneNumber = phonenumber;
            Email = email (;)
        }
    }

class Customer : Person
{
public bool IsPremium { get; set; }

public Customer(string lastName)
{
LastName = lastName;
}
}

    A. 9
    B. 7
    C. 12
    D. 4 -
*/
