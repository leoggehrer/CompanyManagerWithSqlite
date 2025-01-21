# CompanyManager

------

**Lernziele**

- Diese Vorlage dient als Ausgangspunkt für verschiedenste Demos im Unterricht.

## CompanyManager

Das Projekt **'CompanyManager'** ist ein kleines datenzentriertes Anwendungsbeispiel mit welchem die Erstellung eines Software-Systems dargestellt werden soll. Aufgrund der Komplexität, die ein Software-System im Allgemeinem darstellt, ist die Erstellung des Beispiels in mehreren Themenbereichen unterteilt. Jedes Thema beginnt mit dieser Vorlage und wird entsprechend der jeweiligen Aufgabenstellung erweitert. 

### Vorlage

In dieser Vorlage gibt es bereits zwei unterschliedliche Projekte:

|Name|Beschreibung|
|---|---|
|CompanyManager.ConApp| Eine Konsolen-Anwendung zum Starten der Anwendung und Ausführung des Programm-Menüs. Die entsprechenden Menü-Funktionen müssen implementiert werden und sind mit *throw new NotImplementedException()* markiert. |
|CompanyManager.Logic| In diesem Projekt sind alle Schnittstellen und der Datenzugriff definiert. |
|CompanyManager.Logic.Contracts| In diesem Abschnitt befinden sich alle Schnittstellen. |
|CompanyManager.Logic.DataContext| In diesem Abschnitt befindet sich der Data-Kontext (`CompanyManagerContext`). |

### Datenstruktur

Die Datenstruktur vom 'CompanyManager' ist einfach und besteht im wesentlichen aus 3 Komponenten welche in der folgenden Tabelle zusammengefasst sind:

|Komponente|Beschreibung|Grösse|Mussfeld|Eindeutig|
|---|---|---|---|---|
|**Company**|||||
|*Name*|Name und der Firma|256|Ja|Ja|
|*Address*|Adresse der Firma|1024|Nein|Nein|
|**Customer**|||||
|*CompanyId*|Fremdschüssel zur Firma|int|Ja|Nein|
|*Name*|Name des Kunden|256|Ja|Ja|
|*Email*|Email des Kunden|128|Ja|Ja|
|**Employee**|||||
|*CompanyId*|Fremdschüssel zur Firma|int|Ja|Nein|
|*FirstName*|Vorname des Mitarbeiters|64|Nein|Nein|
|*LastName*|Nachname des Mitarbeiters|64|Nein|Nein|
|*Email*|Email des Kunden|128|Ja|Ja|
|**Hinweis**|Alle Komponenten haben eine eindeutige Identität (Id)||||
|*|*Natürlich können noch weitere Attribute hinzugefügt werden.*||||

Aus dieser Definition kann ein entsprechendes Objektmodell abgeleitet werden, welches nachfolgend skizziert ist:

|Komponente|Relation|Komponente|
|---|---|---|
|**Company**|1:n|Customer|
|**Company**|1:n|Employee|

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
