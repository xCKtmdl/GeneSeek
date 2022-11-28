using Newtonsoft.Json;
using System;
using System.Collections.Generic;



public class Snapshot
{
    private List<int> data = new List<int>();
    private readonly int origSize;
    private readonly int[] orig;
    

    public Snapshot(List<int> input)
    {
        origSize = input.Count;
        data = input;
        orig = input.ToArray();
    }

    public List<int> Restore()
    {
        return this.orig.Take(origSize).ToList();
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