using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Delegálás, formok közti kommunikáció
/// </summary>

public class Modositas
{
    public string vNev { get; set; }
    public string kNev { get; set; }
    public string kartyaSzam { get; set; }
    public double egyenleg { get; set; }
}

public class Login
{
    public string User { get; set; }
    public string Pass { get; set; }
}

/// <summary>
/// Add item to List:
/// List.Items.Add(new Elem("DisplayValue", "HiddenValue");
/// Get hidden value of selected item:
/// string hValue = ((Elem)List.SelectedItem).HiddenValue;
/// </summary>

public class Vasarlo
{
    string displayValue;
    string vezetekNev;
    string keresztNev;
    string kartyaSzam;
    double egyenleg;

    //Constructor
    public Vasarlo (string d, string vNev, string kNev, string kSzam, double egyenlegC)
    {
        displayValue = d;
        vezetekNev = vNev;
        keresztNev = kNev;
        kartyaSzam = kSzam;
        egyenleg = egyenlegC;
    }
    
    //Accessor
    public string VezetekNev
    {
        get
        {
            return vezetekNev;
        }
    }

    public string KeresztNev
    {
        get
        {
            return keresztNev;
        }
    }

    public string KartyaSzam
    {
        get
        {
            return kartyaSzam;
        }
    }

    public double Egyenleg
    {
        get
        {
            return egyenleg;
        }
    }
    
    //Override ToString method
    public override string ToString()
    {
        return displayValue;
    }


}

public class Termek
{
    string displayValue;
    string termekID;
    string nev;
    double ar;

    public Termek(string d, string tID, string nevC, double arC)
    {
        displayValue = d;
        termekID = tID;
        nev = nevC;
        ar = arC;
    }

    public string TermekID
    {
        get { return termekID; }
    }

    public string Nev
    {
        get { return nev; }
    }

    public double Ar
    {
        get { return ar; }
    }

    public override string ToString()
    {
        return displayValue;
    }
}