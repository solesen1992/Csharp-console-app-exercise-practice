// Initialize the data layer
using Exercise_JavaToCsharp3.Control;
using Exercise_JavaToCsharp3.Data;
using Exercise_JavaToCsharp3.Tui;

// Create an instance of DataService
DataService dataLayer = new DataService(); 
// Load employee data into a list
var employeeData = dataLayer.InitializeData(); 

/* 
 * Initialize the control layer
 */
// Create an instance of EmployeeController
EmployeeController controlLayer = new EmployeeController(); 
// Pass the employee data to the controller
controlLayer.InitializeData(employeeData); 

/* 
 * Initialize the TUI (Text User Interface) layer and display the data
 */
// Create an instance of Tui, passing the controller
Tui tui = new Tui(controlLayer); 
// Call the method to display employee information on the console
tui.DisplayEmployees(); 
