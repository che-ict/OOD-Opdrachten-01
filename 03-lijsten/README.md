# 03-Lijsten
In deze opdracht heb je verschillende functies die iets met een lijst met namen erin doen. Zorg dat ze allemaal werken zoals omschreven

## MetDonald
Voeg de naam 'Donald' toe aan de lijst
```csharp
var namen = List<string>(){"Jantje"};
var resultaat = MetDonald(namen);
// resultaat is ["Jantje", "Donald"]
```


## EersteDrie
Geef de eerste drie namen uit de lijst terug
```csharp
var namen = List<string>{"Jan", "Piet", "Rob", "Kip"}
var resultaat = EersteDrie(namen)
// resultaat is ["Jan", "Piet", "Rob"]
```

## LaatsteDrie
Geef de laatste drie namen uit de lijst terug
```csharp
var namen = List<string>{"Jan", "Piet", "Rob", "Kip"}
var resultaat = LaatsteDrie(namen)
// resultaat is ["Piet", "Rob", "Kip"]
```

## ZonderGoofy
Haal alle keren dat 'Goofy' in de lijst staat eruit
```csharp
var namen = List<string>{"Jan", "Piet", "Goofy", "Kip"}
var resultaat = ZonderGoofy(namen)
// resultaat is ["Jan", "Piet", "Kip"]
```

## ZonderE
Geef een lijst terug met alle karakters die geen letter 'e' in hun naam hebben
```csharp
var namen = List<string>{"Jan", "Piet", "Rob", "Kip", "Marie"}
var resultaat = ZonderE(namen)
// resultaat is ["Jan", "Rob", "Kip"]
```