namespace Zad;

public class ContainerFreezer(int productId) : Container
{
    private readonly int _productId = productId;
    private double _temperature;
    
    public override string ToString()
    {
        return base.ToString() + $"-F-{_seriesNr}";
    }
}