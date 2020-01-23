using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello how could i help you today?");
            bool done = false;
            people myPeople = new people();
            while(done != true)
            {
                string command = Console.ReadLine();
                if (command == "add person")
                {
                    Console.WriteLine("ok we will add somebody!");
                    Console.WriteLine("Name?");
                    String personName = Console.ReadLine();
                    Console.WriteLine("Age?");
                    int personAge = Convert.ToInt32(Console.ReadLine());

                    myPeople.add(new person(personName,personAge));
                }
                else if (command == "find person")
                {
                    Console.WriteLine("ok what is the name of the person?");
                    person personFound = myPeople.getPerson(Console.ReadLine());
                    if (personFound != null)
                    {
                        Console.WriteLine(personFound.name);
                        Console.WriteLine(personFound.age);
                    }
                    else
                        Console.WriteLine("person not found by that name");
                }
                else if(command=="show everyone")
                {
                    myPeople.showEveryone();
                }
                else if (command == "done")
                {
                    Console.WriteLine("ok");
                    Console.WriteLine("goodbye!");
                    done = true;
                }
                else
                    Console.WriteLine("invalid command");
            }
        }
    }
}
