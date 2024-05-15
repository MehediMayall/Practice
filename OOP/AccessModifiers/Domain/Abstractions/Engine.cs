namespace Domain;
public abstract class Engine
{
    public Guid Id;
    private string name;
    protected string EngineName;
    internal string SerialNumber;
    public abstract void Start();
    public abstract void Stop();
    protected abstract void StartAC();
    protected abstract void StopAC();

    internal abstract void PlayMusic();
    internal abstract void StopMusic();
}