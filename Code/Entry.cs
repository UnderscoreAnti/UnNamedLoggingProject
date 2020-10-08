using Godot;
using System;
using System.Collections.Generic;

public class Entry : Node2D
{
    [Export]
    string EntryName;
    string DateEntryCreated;
    string DateEntryEdited;
    int EntryListCount;
    List<string> ListEntries = new List<string>();

    public override void _Ready()
    {
        DateEntryCreated = Convert.ToString(DateTime.Now);
    }
}
