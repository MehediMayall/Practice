using DisposeAndFinalize;

// This code sample won't call the destruct of the EmailService class.
// because the instance of the EmailService class is still in the scope
// by calling the Garbase collector will have no effects on the destructor.
var emailService = new EmailService();
emailService.Send();

GC.Collect();


// Following code will call the EmailService destructor because 
// sendEmail() function has a scope and when EmailService will go out of the scope
// then calling the Garbase Collection to collect the garbase that will trigger the
// destructor of the Email Service 
void sendEmail() => new EmailService().Send();

sendEmail();
GC.Collect();



// Example of IDisposable

// using(var logger = new LogService())
// {
//     logger.log("This world will be collapsed soon!");
// }
// // GC.Collect();

// this code sample will call the dispose method
// because it was constructed using keyword
using var logService = new LogService();
logService.log("The world is being destructed!");
// GC.Collect();


// void destroyIt() => new LogService().log("Destroy It!");
// destroyIt();
// GC.Collect();
