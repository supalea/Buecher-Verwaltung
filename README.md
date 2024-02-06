# Bücherverwaltungsprogramm

- Form 1 Login 
- Form 2 Registrierung
- Form 3 Hauptseite
- Form 4 Bücherbearbeitung und hinzufügen
- Form 5 Quiz
- Form 6 Buch Details

Datenbank und den Bilder Ordner in temp speichern oder Pfad anpassen
```
con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
   "Data Source=C:\\temp\\Buecher_verwaltung.accdb";
```

DataGridView hier DGV
<br><br>
## Login (Form1)
- Benutzername und Passwort Abfrage über die Datenbank. 
- Prüft ob Benutzername existiert
- Bei klick auf Augensymbol kann man sich das Passwort anzeigen lassen
- Über Registrierung Button kommt man auf Form2 Registrierung
<br><br>
## Registrieren (Form2)
- Nachname und Vorname     - Darf nur Buchstaben enthalten
- Email - Buchstaben, Zahlen und Sonderzeichen dann ein @ dann Buchstaben, Zahlen und Sonderzeichen ein Punkt und Buchstaben, Zahlen und Sonderzeichen
- Username - Wird geprüft ob der Username in der Datenbank schon existiert
- Passwort - Prüft Mindestens 6 Zeichen, Groß- und Kleinschreibung, min. 1 Ziffer und 1 Sonderzeichen <br><br>
Bei klick auf Registrieren speichert es die Daten in der Datenbanktabelle User. <br>
Form2 schließt sich und man kann im Login sich anmelden mit den eingegebenen Daten. <br>
Bei klick auf Login oder Enter geht Form 3 auf.
<br><br>
## Hauptseite (Form3)
Beim öffnen der Hauptseite lädt die Form3: 
-	alle Datensätze aus der Datenbanktabelle Buecher in die DGV mit den Spalten: Titel, Autor, Erscheinungsjahr, ISBN, Seiten, Genre, Sprache und einem Button für mehr Informationen.
-	auf die linke Seite die Top 10 Bücher nach Beliebtheit in die Listbox
-	unter der Listbox Informationen über die ausgeliehenen Bücher
-	unter die DGV die Filter Comboboxen und das Suchfeld
-	auf die rechte Seite die … Buttons
-	unten rechts das Quiz 
<br><br>
## Klick auf Einfügen (Form4)
- Form4 öffnet sich 
- Titel, Autor, Erscheinungsjahr, ISBN,  Seitenanzahl, Genre, Sprache, Beschreibung
- Speichernbutton klick:  
- Die Daten werden in die Datenbank und ins DGV gespeichert 
<br><br>
## Klick auf Bearbeiten (Form4)
- Form4 öffnet sich auch
- Daten werden aus der DGV gelesen und in die folgenden Textfelder eingefügt:
- Titel, Autor, Erscheinungsjahr, ISBN,  Seitenanzahl, Genre, Sprache, Beschreibung
- Speichernbutton klick:  
 -Die Daten werden in die Datenbank und ins DGV geupdated 

## Klick auf Löschen
- Löscht die selektierte Reihe aus der DGV und aus der Datenbank

## Klick auf Ausleihen 
- Prüft erst ob das Buch schon ausgeliehen wurde von einem anderen Nutzer oder ob der Nutzer schon ein Buch ausgeliehen hat.
- Regel: Ein Nutzer kann nur ein Buch gleichzeitig ausleihen
- Wenn das selektierte Buch nicht ausgeliehen wurde und der Nutzer noch kein Buch ausgeliehen hat dann wird das Buch ausgeliehen.
- Das ausgeliehene Buch wird grau hinterlegt und die Ausleihen-Übersicht wird aktualisiert mit den Daten:
	- welcher User ausgeliehen hat
	- welches Buch ausgeliehen wurde
	- Rückgabe in wieviel Tagen
	- Rückgabe bis welches Datum

## Klick auf Zurückgeben
- Prüft erst ob das Buch von dem Nutzer ausgeliehen wurde.
- Wenn ja kann er das Buch zurückgeben. 
- Die Übersicht verschwindet und eine Bewertungsfrage erscheint. 
- Man kann eine positiv oder eine negative Bewertung abgeben die dann in der Datenbank gespeichert wird und in der Top 10 Listbox wiedergespiegelt wird. 

## Klick auf Quiz (Form5)
- Öffnet Form 5 und es erscheint per Zufall der Titel eines Buches und man muss in das Eingabefeld den Autor eingeben. 
- Wenn man richtig liegt wird es grün, man bekommt einen Punkt und dann kommt die nächste Frage. Wenn eine Antwort Falsch ist wird es rot und das Spiel ist vorbei. 
- Man kann oben links auf das DropDown Menü klicken und das Spiel neu starten oder es beenden.  

## Suche
- Man gibt bei der Suche etwas ein und kann dann nach Titel, Autor, ISBN, Genre oder Sprache Filtern.
- Bei klick auf die Suche zeigt es die Bücher nach den Filteroptionen an.
- Wenn das Suchfeld geleert wird, werden wieder alle Daten in der DGV angezeigt.

Bei klick auf ein Buch in der Top 10 Listbox oder auf den “Mehr“ Button in der DGV wird Form6 geöffnet, in dem nochmal mehr Buchdetails stehen. 





