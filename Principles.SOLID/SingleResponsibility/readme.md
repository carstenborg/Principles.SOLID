**The Single Responsibility Principle** dictates, that a Class should have: 

> one and only one reason to change, meaning that a class should have only one job

Code that doesn’t follow the Single Responsibility Principle might have a class that does too many things at once. For example, let’s say we have an Employee class that has properties for an employee’s ID, name, and salary, as well as methods for saving the employee to a database and sending an email notification to their manager. 

This class violates the Single Responsibility Principle because it has multiple reasons to change - if we need to change how employees are saved to the database or how email notifications are sent, we would need to modify this class.

By separating these responsibilities into different classes, we can make our code more modular and easier to maintain.