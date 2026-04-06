W05 Mindfulness Program Structure

What does the program do?

This program leads the user through different mindfulness tasks. The user selects a task from a menu, sets the length of time, and the program executes the selected task using instructions and visual countdown animations.

User Input: Selection from menu, duration in seconds
Output: Task description, countdown/spinning icons, reminders 
How does it end? At the end of the selected period of time, the program displays a summary, and the menu reappears.

Classes and Responsibilities
Activity (base class)

Stores the name, description, and duration shared by all activities
Handles starting/ending messages and animation helpers
Member Variables	Type
_name	string
_description	string
_duration	int
Methods	Purpose
DisplayStartingMessage()	Show name, description, ask for duration
DisplayEndingMessage()	Show completion message
ShowSpinner(int seconds)	Animate a spinner for given seconds
ShowCountDown(int seconds)	Count down with numbers
BreathingActivity : Activity

Guides user to breathe in and out repeatedly for the duration
Member Variables	none beyond base
Methods	Purpose
Run()	Alternate breathe-in/breathe-out countdowns
ReflectingActivity : Activity

Shows a random reflection prompt, then cycles through questions
Member Variables	Type
_prompts	List<string>
_questions	List<string>
Methods	Purpose
Run()	Display prompt, loop through questions with spinner
GetRandomPrompt()	Return a random prompt from the list
DisplayQuestions()	Show questions one at a time with pauses
ListingActivity : Activity

Shows a prompt and asks the user to list as many items as they can
Member Variables	Type
_prompts	List<string>
Methods	Purpose
Run()	Show prompt, collect user items, display count
GetRandomPrompt()	Return a random prompt from the list
Class Diagram
           ┌─────────────────────────┐
           │        Activity         │
           ├─────────────────────────┤
           │ - _name : string        │
           │ - _description : string │
           │ - _duration : int       │
           ├─────────────────────────┤
           │ + DisplayStartingMessage│
           │ + DisplayEndingMessage  │
           │ + ShowSpinner()         │
           │ + ShowCountDown()       │
           └────────────┬────────────┘
                        │
          ┌─────────────┼─────────────┐
          ▼             ▼             ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│  Breathing   │ │  Reflecting  │ │   Listing    │
│  Activity    │ │  Activity    │ │  Activity    │
├──────────────┤ ├──────────────┤ ├──────────────┤
│  (no extras) │ │ - _prompts   │ │ - _prompts   │
├──────────────┤ │ - _questions │ ├──────────────┤
│ + Run()      │ ├──────────────┤ │ + Run()      │
└──────────────┘ │ + Run()      │ │ + GetRandom  │
                 │ + GetRandom  │ │   Prompt()   │
                 │   Prompt()   │ └──────────────┘
                 │ + Display    │
                 │   Questions()│
                 └──────────────┘