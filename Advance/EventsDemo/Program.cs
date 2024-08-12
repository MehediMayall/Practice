using EventsDemo;
using static System.Console;



// Publisher
var video = new Video{ Filename = "video 1", FileType= "mp4", Size = 25};
var encoder = new VideoEncoder();


// Subscriber 01: Email Service
var emailService = new EmailService();
encoder.VideoEncoded += emailService.OnVideoEncoded;


// Subscriber 02: SMS Service
var smsService = new SMSService();
encoder.VideoEncoded +=  smsService.OnVideoEncoded;


encoder.Encode(video);


