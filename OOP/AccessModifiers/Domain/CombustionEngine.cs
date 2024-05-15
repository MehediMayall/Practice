namespace Domain;

public class CombustionEngine: Engine
{
    public override void Start()
    {
        System.Console.WriteLine("Engine successfully started");

        // StartAC() function is accessible from the derived class
        StartAC();
    }

    public override void Stop()
    {
        throw new NotImplementedException();
    }

    protected override void StartAC()
    {
        throw new NotImplementedException();
    }

    protected override void StopAC()
    {
        throw new NotImplementedException();
    }

    internal override void PlayMusic()
    {
        throw new NotImplementedException();
    }

    internal override void StopMusic()
    {
        throw new NotImplementedException();
    }
}