namespace Zad;


// Can hold sth dangerous like petrol or not harmful like milk
public class ContainerForLiquids(bool dangerous) : Container, IHazardNotifier
{
    private readonly bool IsLoadedWithDangerous = dangerous;
    
    public void NotifyOfDanger()
    {
        Console.WriteLine("Danger in:" + _seriesNr);
    }

    public override void Load(double massOfLoad)
    {
        var maxContent = _maxCarriage * (IsLoadedWithDangerous ? 0.5 : 0.9);
        
        if (massOfLoad + _masOfContent > maxContent)
            NotifyOfDanger();
        else
            _masOfContent += massOfLoad;
        
    }

    public override string ToString()
    {
        return base.ToString() + $"-C-{_seriesNr}";
    }
}