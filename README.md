#  Calculator KJ 

The goal of the project is to automate releases at each commit push on the integrated branch of the CI/CD pipeline for .NET Core project.

# How it works

The console application will use a class library in .dll file to hide the code, which is made of methods for arrhythmic calculations. 
Each method will have a unit test, if a unit test doesn't pass, then the pipeline will not be validated and therefore the automation will not be done.  
  
- The project uses 3.1 .NET Core, if you use a another older or recent version, change the .yaml file with your current version.  

