using System;
using System.Collections.Generic;
using System.Text;

public class KodePaket
{
    private Dictionary<string, string> _kodePaketData { get; set; } = new Dictionary<string, string>();
    public Dictionary<string, string> KodePaketData
    {
        get => _kodePaketData;
        set => _kodePaketData = value;
    }

    public KodePaket()
    {
        KodePaketData.Add("Basic", "P201");
        KodePaketData.Add("Standard", "P202");
        KodePaketData.Add("Premium", "P203");
        KodePaketData.Add("Unlimited", "P204");
        KodePaketData.Add("Gaming", "P205");
        KodePaketData.Add("Streaming", "P206");
        KodePaketData.Add("Family", "P207");
        KodePaketData.Add("Business", "P208");
        KodePaketData.Add("Student", "P209");
        KodePaketData.Add("Traveler", "P210");
    }

    public string? GetKodePaket(string namaPaket)
    {
        KodePaketData.TryGetValue(namaPaket, out string kode);

        return kode;
    }

}