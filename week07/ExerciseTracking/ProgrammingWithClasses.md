Programming with Classes - Basic Concepts

The object-oriented approach relies on four essential concepts: abstraction, encapsulation, inheritance, and polymorphism. I have used all four in my projects, including the Eternal Quest and Exercise Tracking applications.

1. Abstraction
Abstraction refers to reducing complex systems to their essential components and ignoring unnecessary elements. For example, in the Exercise Tracking application, I developed an abstract Activity class that included methods such as GetDistance(), GetSpeed(), and GetPace(), but did not implement them. This design enables focusing on how each activity behaves while ignoring implementation specifics. Abstraction helps make the program more flexible since I can introduce new types of exercises (rowing, hiking) without modifying the existing framework by implementing these methods.

2. Encapsulation
Encapsulation hides internal state representation from outside entities and allows accessing data only using provided methods. In my applications, all member variables (for example, _distance, _speed, and _laps) remained private and could be accessed via public methods. This technique guarantees consistency in data representation and eliminates accidental modifications. Moreover, it contributes to increased flexibility, as I can easily modify how data is stored or processed within a class later on.

3. Inheritance
Inheritance lets us build a new class based on an existing one, acting like a blueprint to share code. In my Exercise Tracking project, I created a base Activity class holding shared properties like date and duration. By having Running, Cycling, and Swimming inherit from this base class, I avoided re-writing code for every new type of exercise. This keeps the program organized, and if I want to add "Walking," I just inherit from Activity without restructuring the entire program

4. Polymorphism
Polymorphism is about treating different subclasses as their parent type, allowing them to exhibit unique behaviors through a shared interface. I stored all activities—running, cycling, etc.—in a single List<Activity>. When I looped through them to call GetSummary(), the program didn't need to know the specific type.

foreach (Activity activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}

 Each activity produced its own unique summary, making the system flexible and allowing me to add new, specialized activities later without changing the core loop.

Conclusion
By using inheritance and polymorphism, I built a program that is organized, DRY (Don't Repeat Yourself), and easy to scale. Instead of treating every activity as a separate, isolated task, I created a structure where functionality is reused. This approach is highly efficient for real-world software, making maintenance straightforward and extension simple.