using EventsDemo;
using static System.Console;



// Publisher
var video1 = new Video{ Filename = "video 1", FileType= "mp4", Size = 25};
var video2 = new Video{ Filename = "video 2", FileType= "wva", Size = 25};

var encoder = new VideoEncoder();


// // Subscriber 01: Email Service
// var emailService = new EmailService();
// encoder.VideoEncoded += emailService.OnVideoEncoded;


// // Subscriber 02: SMS Service
// var smsService = new SMSService();
// encoder.VideoEncoded +=  smsService.OnVideoEncoded;


// Subscriber 01: Email Service
encoder.Subscribe(new EmailService().OnVideoEncoded);


// Subscriber 02: SMS Service
var smsService = new SMSService();
encoder.Subscribe(smsService.OnVideoEncoded);

encoder.Encode(video1);


// Remove Subscriber
encoder.Unsubscribe(smsService.OnVideoEncoded);
encoder.Encode(video2);




