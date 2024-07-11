using AsyncOps;

var emailService = new EmailService();

foreach(int x in Enumerable.Range(1,5))
{
    System.Console.WriteLine($"Person {x}");
    // await emailService.SendAsync();
    emailService.Send();
}
