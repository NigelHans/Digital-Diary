<p align="center">
   <img src="ReadMe/Header.png" alt="Header="max-width: 100%; height: auto;">
</p>

# DIGITAL DIARY 💻📒
Welcome to the **Digital Diary Repository**! More than just lines of code — this Digital Diary turns your console into a vault of memories. Crafted with C#'s object-oriented principles and smart file handling, it lets you pen down your thoughts, flip through past entries, and search for moments that matter — all within a clean, text-based interface.

Explore this repository and start writing your story, one entry at a time. 📝
<br>
<br>

## 📝 Overview of Contents
📒 [**1. Project Overview**](#proj_overview)  
📒 [**2. Application of OOP**](#proj_oop)  
📒 [**3. Application Ignition Guide**](#proj_guide)  
📒 [**4. Directory Map**](#proj_direct)  
📒 [**5. Sample Output**](#proj_output)   
📒 [**6. Project Developer**](#proj_developer)  
📒 [**7. Acknowledgement**](#proj_acknowledge) 
<br>
<br>

## <a id = "proj_overview"> 📝 Project Overview </a> 
**Digital Diary** is a modular, console-based C# application that transforms everyday journaling into a seamless digital experience. Built with **object-oriented principles** and **file handling techniques**, this diary allows users to write, view, and search entries — all stored neatly within a text file. Thus, Whether you're capturing today's reflections or digging into yesterday's thoughts, Digital Diary keeps it all organized and within reach. ✍️

**Here's a glimpse of what it can do:**

<p align="center">
   <img src="ReadMe/Features.png" alt="Header="max-width: 100%; height: auto;">
</p>


---
### 🌟 Digital Diary Features 🌟
#### ✍️**Quick and Easy Entry Creation**  
> Users can easily write a new diary entry through the `Write a New Entry` option, with the text being saved to a file along with a timestamp for easy tracking of when the entry was made.

#### 🔍**Organized Entry Viewing**  
> The `View All Entries` option allows users to view all their past diary entries, displayed in an organized format with their respective dates and times, making browsing through past entries convenient.

#### 🗓️**Date-Based Searching**  
> The `Search Entry by Date` feature enables users to quickly find entries from specific dates, streamlining the process of locating important memories or thoughts from a particular day.

#### 🗂️ **File-Based Storage**  
> The app uses file handling methods like `StreamWriter` and `StreamReader` to save and retrieve diary entries from a diary.txt file, ensuring that entries are stored persistently even after the application is closed.

#### 💻 **Simple Console Interface**  
> The console-based interface provides a minimalistic and user-friendly experience with a menu-driven approach, allowing users to easily select options and interact with the diary features through simple text input and output.

---

## <a id = "proj_oop"> 📝 Application of OOP </a> 
The **Digital Diary** application uses two key **Object-Oriented Programming (OOP) principles**,  mainly **encapsulation** and **abstraction**. Thus, this section focuses on how these key concepts were implemented to enhance functionality and maintainability. Below is a detailed breakdown of the implementation of the following concepts:

| **OOP Principle** | **Implementation**                                                                                                                                                                                                                                                                                                         |
|-------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Encapsulation**  | The `filePath` field is kept private in the `Diary` class, preventing direct access to the file location from outside the class. Users interact only with the public methods (`WriteEntry()`, `ViewAllEntries()`, and `SearchByDate()`), which control the functionality of writing, viewing, and searching diary entries. This ensures that the internal details of file handling, such as opening, reading, and writing to the file, are hidden and protected from direct manipulation, maintaining the integrity of the program. |
| **Abstraction**    | Abstraction is implemented by providing users with simple, high-level methods like `WriteEntry()`, `ViewAllEntries()`, and `SearchByDate()`. These methods handle the complexity of file reading, writing, and searching entries, allowing users to perform actions without understanding the internal logic. The user only needs to interact with these methods, while the implementation details—such as managing file operations—are abstracted away, making the interface easier to use and more intuitive. |
<br>

## <a id = "proj_guide"> 📝 Application Ignition Guide </a> 
### 🌟Prerequisites🌟
To run the **Digital Diary** application, you need to have the following installed:

- **📥 .NET SDK** (version 5.0 or higher)  
  Download it from the official [Microsoft .NET Download Page](https://dotnet.microsoft.com/download)

- **📥 IDE or Code Editor**  
  You can use any C# compatible IDE such as:
  - [Visual Studio](https://visualstudio.microsoft.com/) 
  - [Rider by JetBrains](https://www.jetbrains.com/rider/)
  - [Visual Studio Code](https://code.visualstudio.com/) 

---

### 🌟Steps to Run the Application🌟
Follow these steps to get your **Digital Diary** up and running:
#### 1. Clone the Repository
> Clone this repository to your local machine using Git:
```bash
git clone https://github.com/yourusername/digital-diary.git
```
#### 2. Navigate to the Project Folder
> Open a terminal or command prompt and navigate to the folder where you cloned the repository:
```bash
cd digital-diary
```
#### 3. Restore Dependencies
> Run the following command to restore the project's dependencies:
```bash
dotnet restore
```
#### 4. Build the Application
> Build the project using the following command:
```bash
dotnet build
```
#### 5. Run the Application
> Once the build is complete, run the application with:
```bash
dotnet run
```

---

## <a id = "proj_direct"> 📝 Directory Map </a> 
## <a id = "proj_output"> 📝 Sample Output </a> 
## <a id = "proj_developer"> 📝 Project Developer </a> 
<p align="center">
   <img src="ReadMe/Developer.png" alt="Header="max-width: 100%; height: auto;">
</p>

### 🌟Meet the Developers🌟
---

The **Digital Diary** project was developed by second-year Computer Science students from Batangas State University - The National Engineering University (BatStateU-TNEU), Alangilan Campus,  of class **CS-2201**, as part of the **CS222 - Advanced Object-Oriented Programming** course. The goal was to apply object-oriented programming principles and file handling techniques in creating a Digital Diary application, transforming theoretical concepts into a practical, functional software solution.

For further information or inquiries, below are the contact details of the developers:
| **Name**            | **Gmail**                | **GitHub**               |
|---------------------|--------------------------|--------------------------|
| **De Castro, Angel Lyka Mae**    | 23-09904@g.batstate-u.edu.ph     | [GitHub Profile](https://github.com/developer1) |
| **Crisostomo, Erix Steven**    | 23-01893@g.batstate-u.edu.ph     | [GitHub Profile](https://github.com/developer2) |
| **Nunez, Nigel Hans**    | 23-07848@g.batstate-u.edu.ph    | [GitHub Profile](https://github.com/developer3) |
| **Vael, Anthonina Dhapniella C.**   | 23-04485@g.batstate-u.edu.ph     | [GitHub Profile](https://github.com/developer4) |
<br>

## <a id = "proj_acknowledge"> 📝 Acknowledgement </a> 
We, the developer of this project would like to express our heartfelt gratitude to our mentor for the CS222 - Advanced Object-Oriented Programming course, **Ms. Fatima Marie P. Agdon**. It is through her constant guidance, patience, and the valuable knowledge she shared with us that we were able to accomplish this project. Her support and encouragement were crucial in helping us understand the concepts of object-oriented programming and file handling, making this project possible. We truly appreciate her dedication to teaching and her efforts in shaping us into better programmers. 

**Thank you, Ms. Agdon!** ✨
<br>

