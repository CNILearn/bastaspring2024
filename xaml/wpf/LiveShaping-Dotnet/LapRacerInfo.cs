namespace LiveShaping;

public enum PositionChange
{
    None,
    Up,
    Down,
    Out
}

public partial class LapRacerInfo : ObservableObject
{
    public Racer? Racer { get; set; }

    [ObservableProperty]
    private int _lap;

    [ObservableProperty]
    private int _position;

    [ObservableProperty]
    private PositionChange _positionChange;
}
