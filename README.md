# Cineplex Cinema
## Project Description 
You have been assigned the task to design and implement a Windows Forms application with C#, called
Cineplex using Visual Studio 2022.<br><br>
This application is designed to efficiently manage the CinéPlex movie list, by adding a new film to the list,
searching for a film in the list, deleting a film from the list, or modifying film data.<br><br>
At any time, you can save the film list to a file and load the films in the file into memory.<br><br>
A film has a number, a title, a category (Drama, Action, Humor, War, ...), a language (English, French, ...),
a duration evaluated in hours and minutes and a main actor.<br><br>

Your application must meet the following requirements:
1. A film is identified by a code, title, category, language, actor, and duration
2. An actor is identified by a first name and a last name.
3. The film category could be: Action, Thriller, Drama, History, Mystery, and so on.
4. The film language could be: English, French, Spanish, and so on.
5. The film duration is evaluated in hours and minutes.<br><br>

## Implementation (Business Layer)
**Business Layer**<br><br>
 **1.1 - Create the following data types:<br>**
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;```<enum> EnumCategory```<br>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;```<enum> EnumLanguage```<br>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;```<class> Time```<br>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;```<class> Person```<br>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;```<class> Film```<br><br>
 
 **1.2 - Create the class diagram named ClassDiagram_Cineplex.cd<br>**<br>
 **Business requirements:<br>**
 1. The actor is a reference variable of the Person type (an instance of the Person class).<br>
 2. The film duration is a reference variable of the Time type (an instance of the Time class).<br>
 3. A film must not exceed 4 hours of duration.<br>
 4. The film category must be of EnumCategory type.<br>
 5. The film language must be of EnumLanguage type.<br><br>
 
 **Each class must have:<br>**
 1. Private fields.<br>
 2. Public set/get property for each private field.<br>
 3. Public overloaded constructors: default constructor and constructor with parameters.<br>
 4. Public method returning the object’s state (the string formatting of the current object).<br><br>

## Implementation (Client Layer)
**Build the Client Layer: Windows Forms Application**<br>
**Create a friendly Graphical User Interface to do the following operations:** <br>
1. Add a movie to the list of movies.<br>
2. Print the list of movies.<br>
3. Search for a movie by title<br>
4. Update movie information<br>
5. Remove a movie from the list of movies.<br><br>

**Add the following buttons control in the Main Form:** <br>
1. ADD
2. PRINT
3. UPDATE
4. REMOVE
5. SEARCH
6. RESET
7. EXIT
<br><br>
## Requirements <br>
1. Respect the name convention.
2. Add a name to each control: textbox control, button control, listBox control.
3. Add your student number, first name, last name in the Text property of the Form1.
4. Add your student number, first name, last name in the MessageBox control (at the event Click on the Button EXIT).
5. Delete the 2 folders: bin and obj.
6. Validation:
   1. Hours and minutes must be digits and not empty.
   2. Length must be between 2 and 4 hours.
