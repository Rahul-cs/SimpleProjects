# Simple Calculator using .NET MVC (C#)

- *Run the Visual Studio as administrative user*

- *The code contains no implementation of the exceptional cases like divided by 0, decimals and others.*

### The following is the content of the controller (HomeController) with Action "*Calculate*" performing the calculations and returning the value to the view by *ViewBag*. 

### The initial execution throws an exception of values being *Null* and hence the *if(Request.HttpContext.Request.Method == "POST")* to check the call back. 

![calci](/Images/CalculateController.PNG)

### Below is the content of the view (simple UI) which reads the value from the *ViewBag* and displays the result.

![cview](/Images/CalculateView.PNG)

## Result Screenshot

![cout](/Images/CalculateOutput.PNG)
