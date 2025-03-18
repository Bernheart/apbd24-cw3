namespace Zad;

public class ContainerForGas : Container, IHazardNotifier
{
    protected double _pressure;

    public override void Truncate()
    {
        _masOfContent = _masOfContainer * 0.05;
    }
    

    public void NotifyOfDanger()
    {
        Console.WriteLine("Danger in:" + _seriesNr);
    }
    
    public override string ToString()
    {
        return base.ToString() + $"-G-{_seriesNr}";
    }
}