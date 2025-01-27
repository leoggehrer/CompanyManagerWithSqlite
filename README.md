# CompanyManager With SQLITE

**Lernziele**

- Wie mit dem **CodeFirst** Ansatz eine Datenbank erstellt wird.
- Die Verknüpfung von Datenstrukturen und Datenbanken verstehen.
- Wie **SQLite** als Datenbank mit dem EntityFramework verwendet wird.
- Wie **Constraints** in einer Datenbank definiert werden.

**Hinweis:** Als Startpunkt wird die Vorlage [CompanyManager](https://github.com/leoggehrer/CompanyManager-Template) verwendet.

## Beschreibung der Vorlage

Den Aufbau und die Beschreibung der Vorlage finden Sie [hier](https://github.com/leoggehrer/CompanyManager-Template).

## Vorbereitung

Bevor mit der Umsetzung begonnen wird, sollte die Vorlage heruntergeladen und die Funktionalität verstanden werden.

### Packages installieren

Um mit dem EntityFramework zu arbeiten, müssen die folgenden Packages installiert werden:

- CompanyManager.Logic
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Sqlite
- CompanyManger.ConApp
  - Microsoft.EntityFrameworkCore.Design

Abhängig von der IDE kann dies über die Konsole oder über die GUI erfolgen. Sie finden eine Anleitung zum Installieren von Nuget-Packages [hier](https://github.com/leoggehrer/Slides/tree/main/NutgetInstall).

### Erstellen der Entitäten

1. Erstellen des Ordners **Entities** im Logik-Projekt.
2. In diesem Ordner werden die **Entitäten** definiert:
3. Erstellen der Entities **Company**, **Customer** und **Employee**.
4. Diese Entitäten müssen die Schnittstellen im Ordner **Contracts** implementieren. Nachfolgend ein Beispiel für die **Company**-Entität:

```csharp
/// <summary>
/// Represents a company entity.
/// </summary>
public class Company : EntityObject, ICompany
{
    #region properties
    /// <summary>
    /// Gets or sets the name of the company.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the address of the company.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the description of the company.
    /// </summary>
    public string? Description { get; set; }
    #endregion properties

    #region methods
    /// <summary>
    /// Copies the properties from another company instance.
    /// </summary>
    /// <param name="company">The company instance to copy properties from.</param>
    public void CopyProperties(ICompany company)
    {
        base.CopyProperties(company);

        Name = company.Name;
        Address = company.Address;
        Description = company.Description;
    }

    /// <summary>
    /// Returns a string representation of the company.
    /// </summary>
    /// <returns>A string that represents the company.</returns>
    public override string ToString()
    {
        return $"Company: {Name}";
    }
    #endregion methods
}
```

Diese Implementierung kann analog für die anderen Entitäten erfolgen.

5. Fügen Sie zusätzlich zu den Entitäten die **Navigationseigenschaften** hinzu. Nachfolgend ein Beispiel für die **Company**-Entität:

```csharp
/// <summary>
/// Represents a company entity.
/// </summary>
public class Company : EntityObject, ICompany
{
    ...

    #region navigation properties
    /// <summary>
    /// Gets or sets the list of customers associated with the company.
    /// </summary>
    public List<Customer> Customers { get; set; } = [];
    /// <summary>
    /// Gets or sets the list of employees associated with the company.
    /// </summary>
    public List<Employee> Employees { get; set; } = [];
    #endregion navigation properties

    ...
}
```

Die Navigationseigenschaften müssen in allen Entitäten definiert werden und die entsprechenden Entitäten referenzieren. Alle Informationen zu Navigationseigenschaften finden Sie in der folgenden Tabelle:
 
| Komponente        | Relation | Komponente |
| ----------------- | -------- | ---------- |
| **Company**       | 1:n      | Customer   |
| **Company**       | 1:n      | Employee   |
| **Customer**      | 1:0..1   | Company    |
| **Employee**      | 1:0..1   | Company    |

Das vollständige Entity-objektmodell ist in der nachfolgenden Abbildung abgebildet:

![Entity-Objektmodell](img/entities.png) 

 6. **Attribute** den Entitäten hinzufügen

Attribute bei Entitäten sind essenziell, um die spezifischen Eigenschaften oder Merkmale der Entitäten in einem Datenmodell zu beschreiben. Sie liefern zusätzliche Informationen, die notwendig sind, um die Entitäten eindeutig zu identifizieren, ihre Eigenschaften zu speichern und ihre Beziehungen zu anderen Entitäten zu definieren. Weitere Informationen zu Attributen finden Sie [hier](https://www.learnentityframeworkcore.com/configuration/data-annotation-attributes).



Nachfolgend ein Beispiel für die **Company**-Entität:
```csharp


### Testen des Systems

- keine Angaben

## Hilfsmitteln

- keine Angaben

## Abgabe

- Termin: 1 Woche nach der Ausgabe
- Klasse:
- Name:

## Quellen

- keine Angabe

> **Viel Erfolg!**
