Definition and Importance of Inheritance

Inheritance is a key concept of the object-oriented programming paradigm. It means that one class, known as the derived or child class, receives by default all properties and functions of another class, known as the base or parent class, without having to reproduce that code. The relationship between a child and a parent class is similar to the natural one between a child and a parent; in other words, the former class gets all behaviors and properties from the latter one but adds something unique on top of them.

Why is Inheritance Important?

Probably the best aspect about inheritance is code reuse and minimization of redundancy. You do not have to reproduce the same logic in different places throughout your application; instead, you create a base class that implements common behavior, and all child classes get it by default. This leads to more manageable programs because if there is some changes to be made, you change only one place where they are implemented, and all other child.

Inheritance in Practice

The Mindfulness Application includes three activities: Breathing, Reflecting, and Listing. The shared components include start message, end message, spinner animation, and the countdown algorithm. Instead of writing the same code three times for every activity, I have created an abstract Activity class which contains the common code, while each activity inheriting from Activity adds its own specific code.

Code:
// Base class containing shared behavior
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
}

// Derived class that inherits from Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();  // inherited from Activity
        // ... breathing logic unique to this class ...
        DisplayEndingMessage();    // inherited from Activity
    }
}

For instance, in this case, BreathingActivity derives from the Activity class with the help of the “: Activity” notation. The constructor invokes the constructor of the base class by utilizing the base notation to pass through the name and description. In this way, when Run() method is executed, it invokes the DisplayStartingMessage() and DisplayEndingMessage() methods that were not written anywhere since they have been inherited from the base class.