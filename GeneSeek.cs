using System;
using System.Collections.Generic;

public class Snapshot
{
    private List<int> data;

    public Snapshot(List<int> data)
    {
        this.data = data;
    }

    public List<int> Restore()
    {
        return this.data;
    }

    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        Snapshot snap = new Snapshot(list);
        list[0] = 3;
        list = snap.Restore();
        Console.WriteLine(string.Join(", ", list)); //It should log "1, 2"
        list.Add(4);
        list = snap.Restore();
        Console.WriteLine(string.Join(", ", list)); //It should log "1, 2"
    }
}