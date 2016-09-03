
Th .Release project is just a duplicate of this one so that tests can be run
against debug and release configuration at the same time in the solution.
(Visual studio doesn't allow the same project to exist in the solution twice)

If you make any changes to this .csproj you'll want to reload the
.Release project in Visual Studio for the changes to take effect

Feel free to modify this .csproj in Visual Studio directly