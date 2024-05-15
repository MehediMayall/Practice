namespace Domain;

public class ElectricEngine: Engine
{
    public override void Start()
    {
        System.Console.WriteLine("Engine successfully started");
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