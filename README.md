# Overview

The purpose of this repository is to practice LINQ.

I have set up:
* A handful of entity classes (see entity class diagram below)
* A DbContext with relevant DbSets
* A helper class to pretty print
* A unit test class with exercises

You clone the repository.

Then you update the Data Source path to the .db file in the FamilyContext. It is currently set to my local path. It must be updated to point to your local db file.

Here is the entity class diagram:

![d](https://github.com/TroelsMortensen/FamilyEfc/blob/master/FamilyEfc/FamilyEntityClassDiagram.png);

## The exercises
In the Queries file you will find a number of empty unit test methods.

The name of the method indicates what question you need to answer, like "how many children has red hair".

It is possible to solve all exercises using only the Families DbSet, you can try this as a challenge.

Your LINQ expression needs to be translateable to SQL, which limits what you can do, compared to what you can do in C#. It _is_, however, possible to solve all exercises, without loading the objects to do extra work.\
So, if you call ToList() at some point, you will have access to more C# functionality than what you can do with just SQL. It might be easier to solve some exercise by calling ToList() earlier, and solving the rest in C#. 
But, again, it is not strictly necessary.
