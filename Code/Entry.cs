using Godot;
using System;
using System.Collections.Generic;

public class Entry : Node2D
{
    [Export]
    string EntryName, DateEntryCreated, DateEntryEdited;
    int EntryListCount;
    List<string> ListEntries = new List<string>();

    public override void _Ready()
    {
        string getout = SetDate();
        GD.Print(getout);
        getout = SetDate(true);
        GD.Print(getout);
    }

    public void AppendEntry(List<string> LE)
    {
        //
    }

    public string SetDate(bool WithTime = false)
    {
        string DateSet;
        DateTime thisDay = DateTime.Today;
        DateSet = thisDay.ToString("d");
        if(WithTime)
            DateSet = thisDay.ToString("g");

        return DateSet;
    }

    public void DeleteEntry(List<string> LE)
    {
        //
    }
}
