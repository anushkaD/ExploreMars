# ExploreMars

## Getting Started
* Open solution file using visual studio (ideally 2017)
* Restore nuget packages
* There are two projects in the solution use the ExploreMars.Test project to run the tests 

## Approch
I have used TDD to come up with the solution and use the three test inputs and out puts (testcases) that was supplied in the test. Then refactored the solution so i would have a safty net when refactoring 
There are 2 more testcases I have added to handle invalid inputs 

## Assumptions
In handling the errors i have assumed that all of the errors that would be generated from this solution will be because of invalid inputs

## TODO
Invalid moving instructions needs to be handled eg:- rover etting instructions to move outside the bounds of the grid.
This can be handled in two ways
1. Rover won't be moved outside the bounds of the grid but the user would not know she/he has given invalid instructions to the rover
2. Throw an appropriately error