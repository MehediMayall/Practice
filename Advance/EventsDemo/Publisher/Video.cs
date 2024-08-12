namespace EventsDemo;


public class Video
{
    public string Filename { get; set; }
    public int Size { get; set; }
    public string FileType { get; set; }

    public override string ToString()=>
        $"Filename: {Filename}, Type: {FileType}, Size: {Size}";
}
