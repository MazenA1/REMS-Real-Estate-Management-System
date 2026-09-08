using Models.DTOs;
using System;

public class UnitSelectedEventArgs : EventArgs
{
    public UnitSelectionDTO Unit { get; }

    public UnitSelectedEventArgs(UnitSelectionDTO unit)
    {
        this.Unit = unit;
    }
}