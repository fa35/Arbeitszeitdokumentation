# Projekt "Arbeitszeitdokumentation"

* Gruppe: 4
* Teammitglieder: Philip Leschke, Michael Große, Judith Neugebauer

## Arbeitseinteilung für die 3-Schichten-Architektur: 

1. Benutzeroberfläche: Judith Neugebauer
2. Fachkonzept: Michael Große
3. Datenhaltung: Philip Leschke

## Problemstellung: 
Der Kunde benötigt eine Software um die Arbeitszeiten der Mitarbeiter übersichtlich abzuspeichern und anzeigen zu lassen. Dies beinhaltet:
* Mitarbeiter
* Projekte
* Arbeitszeiten
* Fahrzeiten (Anfahrt/Abfahrt)
* Übernachtungen

## Sprache
Das Projekt wird in C# programmiert, für das Frontend wird Windows Forms genutzt.

## geplante Datenhaltungen: 

1. relationale Datenbank MySQL
2. XML-basierte Datenhaltung

## Testszenarien:
* Die Datenhaltung wird mit automatisierten Integrationstests des Interfaces getestet.
* Das Fachkonzept wird sowohl automatisierte Integrationstests des Interfaces als auch Unittests beinhalten.
* Die User-Interfaces und das Gesamtprogramm werden mit Schreibtischtests getestet, welche evtl. ebenfalls automatisiert werden.
* Die automatisierten Integrationstests erfolgen mit Travis-CI

## Zeitplanung:

| Meilenstein            | Beschreibung                  | Zwischenprodukt       | Datum      |
|:---------------------- |:----------------------------- |:--------------------- |:---------- |
| MS-1                   | Anforderungsanalyse           | Pflichtenheft         | 02.10.2015 |
|MS-2                    |Entwicklung 1. Prototyp        |1. Prototyp            | 09.10.2015 |
|MS-3                    |Ergänzung um fehlende Komponenten|2. Prototyp          |30.10.2015  |
|MS-4                    |Testphase Prototyp             |                       |20.11.2015  |
|MS-5                    |Vorführung der Software        |Softwareprodukt        |27.11.2015  |

