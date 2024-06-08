# hospital-triage-lesson
Lesson plan designed for kids to get them thinking about how coding is used and how to start thinking about coding problems. Current difficulty is configured for 5th graders but can be adjusted by modifying json files. The worksheets and powerpoints are included in case you decide to modify the lesson (recommended).

## Part 1: Presentation
In the lesson-assets folder there is a .pptx/.pdf called "Elementary Programming." I start the lesson with this artifact. Feel free to use/modify/copy parts of this to suit your needs. As a high level summary it is designed to do the following:
 - Give an agenda as to what we're doing (setting expectations)
 - Talk about who I am to build trust and encourage engagement
 - Ask them about their career aspirations/what they are passionate about (Who you are slide)
 - Define coding at a high level and how it impacts our every day life
 - Have them look at some code and make some guesses as to what it does (an easy exercise from leetcode.com)
 - Run through a logic exercise (hospital simulator) where students try to solve a problem. At the end show how computer code can generate the output quickly and accurately.

## Part 2: Hospital Triage Exercise
This exercise is designed to challenge their ability to consider multiple variables in a time step fashion. The backstory is that when patients arrive at a hospital they need to be triaged based on when they arrived and their relative severity. There are three severity's (A, B, C) with A being the most severe injury and C being the least. I equate the severity to different real life examples like A being cardiac arrest and C being a sprained ankle. The point of the exercise is that the student has to be able to prioritize who gets seen when and by which doctor. They must prioritize the most severe injuries first, then prioritize the person who came in first.

### Instructions for lesson
- Kids group up in pairs
- We do the first 3 patients together
- Show strategy for "hiding" patients that are not in the patient room with your hand/piece of paper so they are not overwhelmed by the information
- If they finish they can do an exercise on code.org (or whatever you want to do so the class doesn't descend into chaos)
- At the end of the lesson bring the class together and walk through the worksheet together while having the students raise their hand to answer.
- Show/run the hospital simulator code to show how fast/easy it was to get an accurate output. You can show the code too if you want. This creates an appreciation for how coding as a skill was used to solve a challenging problem.

### Common student pitfalls
Many students at the 5th grade level will forget about the severity aspect of it and have the doctors see patients by when they arrived. When spotchecking their work on the default difficulty you can rapidly determine if they did this because they will see patient 6 after patient 5. My strategy to help them determine the correct answer is having them erase everything after patient 5 then asking who should be seen next while covering up the people who have not yet arrived with my hand/piece of paper. Seeing the full list of patients often leads to being confused by the data.

### Difficulty
The classes I taught have been 30-35 in size. There is usually only 1 pair that gets the answer right on the first check. Around 60-70% get it right by the end of the exercise. I find this an appropriate difficulty but if you are interested in scaling the difficulty you need to modify the .json files and the worksheet. The json files are located in the source code (Doctors.json and Patients.json). You can add/remove doctors or patients to scale up or down the difficulty. This could also open the door to have students consider "average wait time" based on resource constraints and how adjusting the amount of doctors or patient influx will impact experience.

### Installing/running the source code
This project currently utilizes .NET 6. The easiest way to get up and running is to download and utilize the [Visual Studio IDE](https://visualstudio.microsoft.com/vs/). Alternatively you can install the .NET SDK through chocolatey or download the .NET SDK [manually](https://dotnet.microsoft.com/en-us/download). If you don't want to use visual studio you can open a powershell window, navigate to the Hospital Simulator directory that has the .csproj file and run the project using 
```
dotnet run
```
If you dont want to or can't run the project then I attached a screen shot of the output in the lesson-assets folder.
