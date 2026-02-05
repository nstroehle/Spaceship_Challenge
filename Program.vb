Imports System
Imports System.Numerics
Imports System.Globalization

Module Program
    Sub Main(args As String())
        ' Dashboard?Variablen (realistische Beispielwerte)
        Dim shipClass As String = "Galaxy-Klasse"
        Dim crewCount As Integer = 1014
        Dim missionDays As Integer = 4123
        Dim traveledKilometers As BigInteger = BigInteger.Parse("123456789012345678901234")
        Dim percentAtLightSpeed As Double = 72.3      ' eine Nachkommastelle
        Dim currentRange As Double = 13456.789        ' drei Nachkommastellen

        ' Ausgabe: zwei linksbündige, vertikal ausgerichtete Spalten
        Dim colFormat As String = "{0,-45}{1,-40}"

        Console.WriteLine(colFormat, "Name", "Value")
        Console.WriteLine(New String("-"c, 85))
        Console.WriteLine(colFormat, "Klasse des Schiffs", shipClass)
        Console.WriteLine(colFormat, "Anzahl der Besatzung", crewCount.ToString(CultureInfo.CurrentCulture))
        Console.WriteLine(colFormat, "Anzahl der Missionstage", missionDays.ToString(CultureInfo.CurrentCulture))
        Console.WriteLine(colFormat, "Zurückgelegte Kilometer", traveledKilometers.ToString())
        Console.WriteLine(colFormat, "% der in Lichtgeschwindigkeit zurückgelegten Kilometer", percentAtLightSpeed.ToString("F1", CultureInfo.CurrentCulture))
        Console.WriteLine(colFormat, "Aktuelle Reichweite", currentRange.ToString("F3", CultureInfo.CurrentCulture))
    End Sub
End Module
