using Zad.obj;

namespace Zad;

public class Container
{
    public static int number = 0;
    
    protected double _masOfContent; // In kg
    protected double _height; // In cm
    protected double _masOfContainer; // In kg
    protected double _depth; // In kg
    protected int _seriesNr; // ex. KON-[class]-[id]
    protected double _maxCarriage; // In kg

    public Container()
    {
        _seriesNr = number++;
    }
    public virtual void Truncate()
    {
        _masOfContent = 0;
    }

    public virtual void Load(double masOfLoad)
    {
        if (_masOfContent + masOfLoad < _maxCarriage)
            throw new OverfillException();
        else 
            _masOfContent += masOfLoad;
    }

    public override string ToString()
    {
        return "KON";
    }
}