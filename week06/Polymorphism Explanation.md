Explanation Polymorphism

One of the most essential principles in the OOP programming language is polymorphism which permits treating objects from different classes as objects of the base class and performing operations with them according to different implementations. In other words, polymorphism is considered to mean “one interface, many forms.” Method overriding is usually used to implement it.

Another advantage of polymorphism is that it promotes flexibility and extensibility of the code. Adding new classes to your application does not require changes to the existing code since polymorphic behavior provides for using the same code for objects with different behaviors. For instance, it is possible to develop additional types of goals and use them as any other type of goals in the code.

In my application Eternal Quest, I used polymorphism by creating a base class Goal and implementing several subclasses such as SimpleGoal, EternalGoal, and ChecklistGoal, where each subclass overrides the RecordEvent() method.

List<Goal> goals = new List<Goal>();

goals.Add(new SimpleGoal("Run Marathon", "Complete a marathon", 1000));
goals.Add(new EternalGoal("Read Scriptures", "Daily study", 100));
goals.Add(new ChecklistGoal("Temple Visits", "Attend 10 times", 50, 10, 500));

foreach (Goal goal in goals)
{
    int points = goal.RecordEvent(); // Polymorphism in action
    Console.WriteLine($"Earned {points} points!");
}

Here, despite all objects being of type Goal, each one runs its unique implementation of the RecordEvent() method. This is an instance of polymorphism since a single method call will yield varying results based on the underlying object type.

Polymorphism, in general, is vital since it leads to good design, prevents redundancy, and increases adaptability to changes.