
This project is just a duplicate of the .Debug one so that tests can be run
against debug and release configuration at the same time in the solution.
(Visual studio doesn't allow the same project to exist in the solution twice)

If you make any changes to the .csproj of the .Debug one you'll want
to reload this project in Visual Studio for the changes to take effect

Don't modify this .csproj in Visual Studio directly