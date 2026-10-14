using Models.DTOs;
using System;

public class PropertyAndUnitSelectedEventArgs : EventArgs
{
    public PropertyBasicInfoDTO Property { get; }

    public UnitSelectionDTO Unit { get; }

    public PropertyAndUnitSelectedEventArgs(
        PropertyBasicInfoDTO property,
        UnitSelectionDTO unit)
    {
        Property = property;
        Unit = unit;
    }
}