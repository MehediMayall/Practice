using System.Reflection;

namespace EventsDemo;

public class VideoEncoder
{
    // public delegate void VideoEncoderEventHandler(object source, VideoEventArgs eventArgs);

    public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine($"\n\nEncoding {video.Filename}. Please wait...");
        Thread.Sleep(200);
        Console.WriteLine("Encode completed!");
        Console.WriteLine("=============================== \n");
        OnVideoEncoded(video);
    }

    private void OnVideoEncoded(Video video) =>
        VideoEncoded?.Invoke(this, new VideoEventArgs() { video = video});

    public void Subscribe(EventHandler<VideoEventArgs> subscriber) =>
        VideoEncoded += subscriber;

    public void Unsubscribe(EventHandler<VideoEventArgs> subscriber) =>
        VideoEncoded -= subscriber;
 

}