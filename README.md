# C-SHARP-Lambda-Expression

a lambda expression is a shorthand syntax for defining a delegate or an expression tree. A lambda expression is a way to define a method in a more concise way than using a traditional method declaration.

Here is an example of a lambda expression:

arduino

Func<int, int> square = x => x * x;
In this example, we define a lambda expression that takes an integer parameter x and returns the square of x. We assign this lambda expression to a variable named square of type Func<int, int>. This variable can then be used as a method that takes an integer argument and returns an integer value.

The => symbol is the lambda operator, which separates the input parameters from the expression that defines the method's behavior. In this example, the expression x * x defines the method's behavior.

Lambda expressions can be used in various scenarios, such as LINQ queries, functional programming, and event handling. Here are some more examples:

typescript

// Filter a list using a lambda expression
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(x => x % 2 == 0);

// Sort a list using a lambda expression
var names = new List<string> { "Alice", "Bob", "Charlie" };
var sortedNames = names.OrderBy(name => name.Length);

// Register an event handler using a lambda expression
button.Click += (sender, e) => MessageBox.Show("Button clicked!");
In these examples, we use lambda expressions to filter a list, sort a list, and register an event handler. Lambda expressions provide a concise and readable way to define methods on the fly, without the need to declare a separate method.
