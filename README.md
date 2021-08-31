#  The KJ-Calculator CI/CD (Automated Release and running CI/CD pipeline)

The goal of the project is to automate releases at each commit push on the target branch with a CI/CD pipeline while validating unit tests for .NET Core project.

# How it works

The console application will use a class library in .dll file to hide the code, which is made of methods for arrhythmic calculations. 
Each method will have a unit test, **if a unit test doesn't pass, then the pipeline will not be validated** and therefore the automation will not be done.  
  
- The project uses 3.1 .NET Core, if you use a another older or recent version, change the .yaml file with your current version in the workflows folder (.github/workflows).  
- The project uses a branch named "main", you can change the target branch (push and PR) in the .yaml file.  
- For each release name and tag, I decided to use a value that increments by n+1 with `${{ github.run_number }}` in the .yaml file. If you want to edit, then you can take a look in the [GitHub Docs](https://docs.github.com/en/actions/reference/context-and-expression-syntax-for-github-actions) and use what you want.
- Project dependencies are only the **"ClassLibrary.dll"** file. The "ClassLibrary" folder is not used on the console application or on unit tests. The folder is only intended to show how the methods works. 
- This pipeline only works for **GitHub Actions** (so no GitLab or Jenkins) and for a .NET Core project but the concept remains the same. (have fun with the yaml indentation).

<p align="center">
  <img src="https://i.imgur.com/6uv0hOj.png" width="1050" alt="">
</p>

### Unit Tests

Unit tests are performed on the **xUnit framework**. You can use whatever you want (NUnit, MSTest, ... ).

### Console Application 

The console application is not really useful, the class library would have been enough to demonstrate the POC (proof of concept). But it allows to demonstrate this POC to people who don't know how to code in a "work situation" and in a more visual way. This is written in French and the dialogues are obviously a private joke because I don't have a "KJ de poche". The name of the waifu is : NoIdea-chan.
