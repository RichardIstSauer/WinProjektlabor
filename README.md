# WinProjektlabor

Das Projektlabor am Berufskolleg Rheine ist eine
offene Lernumgebung für Schülerinnen und
Schüler. Hier haben „Maker“ einen Ort
geschaffen, wo eigene Projekte kreativ
verwirklicht werden können.
![image](https://user-images.githubusercontent.com/42067245/115446637-cea80f00-a217-11eb-917e-46a8d45e31b3.png)
Das Projektlabor wächst zunehmend um neue
Maker, Lehrerinnen- und Lehrer, die Projekte
unterstützen, und angeschafftes Inventar.
Ein digitales System soll helfen, die Übersicht zu
behalten. In einer ersten Software mit zugehöriger Datenbank, sollen Ben utzerrechte für die
Nutzung der Maschinen im Projektlabor gesteuert werden. Beispielsweise ist nicht jeder Maker
berechtigt, die CNC-Drehmaschine zu bedienen. Nur ein „Keymember“ mit Administratorrechten soll
in der Lage sein, Rechte für den Zugriff auf bestimmte Maschinen an einen Maker zu vergeben.
Zugriffe auf Maschinen können mit einen USB-Button (im Projekt ein vorbereiteter USB-Stick,
später evtl. ein RFID-Chip) gesteuert werden. Jeder Maker soll in Zukunft einen personalisierten
USB-Button erhalten, über den er identifiziert wird und damit die Rechte zur Bedienung einer
Maschine erhält.
Sowohl Rechteverwaltung als auch Logs (Benutzer und Nutzungszeit einer Maschine) werden in
einer Datenbank verwaltet. Die Datenbank liegt als MySQL-Dump vor (projektlabor.sql).
Sie entwickeln eine C#-Windows-Forms-Software für die Verwaltung der Daten. Dabei sollen Sie
sich systematisch mit dem Lesen- und Schreiben der Daten, Entscheidungen über geeignete
Datenformate und Darstellungsmöglichkeiten der Daten befassen. In einem Fachgespräch sollen
Sie Ihre Planungen und systemischen Entscheidungen darlegen und begründen und gegen
Alternativen abwägen können.
Für die Datenbankoperationen steht Ihnen als programmiertechnische Hilfestellung die Klasse
Dbase.cs mit nützlichen Methoden zur Verfügung. Nützliche Methoden zur automatischen
Erkennung von USB-Sticks stehen in dem Programm WinUsbDetect zur Verfügung.

Das Programm unterscheidet Keymember und Maker. Mitglieder beider Gruppen identifizieren
sich mit Hilfe eines registrierten USB-Sticks (USB-Button) und einer PIN. Für die erste
Einrichtung gibt es noch einen Admin-Zugang mit einem Passwort.
Das Programm startet mit einem neutralen Informationsfenster. Nur Keymember aus der Tabelle
user haben, mit ihrem registriertem USB-Button und ihrer PIN, Zugriff auf die Software und sind
berechtigt, Operationen in der Datenbank vorzunehmen. Jeder Keymember hat volle Rechte im
Programm. Maker sind nicht berechtigt, Mitglieder und Rechte zu verwalten. Sie können sich
mit ihren USB-Button und PIN lediglich eine Maschine zur Benutzung freischalten.
• Ein USB-Button wird beim Einstecken des USB-Buttons in den PC und später an einem
Interface der jeweiligen Maschine ausgelesen. Auf dem USB-Stick befindet sich eine evtl.

versteckte Datei mit einer eindeutigen, evtl. verschlüsselten ID zur Identifizierung des USB-
Buttons.

Das Programmbeispiel „WinUsbDetect“ kann als Anregung genutzt werden, um die System-
Events beim An- und Abmelden des USB-Buttons auszuwerten.

• Das Programm stellt beim Starten eine Verbindung zur Datenbank her. Keymember können sich
einloggen und mit den Daten des Programms arbeiten, einfache Maker können nur die
Maschinen benutzen, für die sie die Rechte zugewiesen bekommen haben.
Keymember haben die Möglichkeit, sich alle Maker anzeigen zu lassen, deren Daten zu
bearbeiten, sowie neue Maker anzulegen. Jedem Maker kann genau ein USB-Button
zugewiesen werden. Die Zuweisung erfolgt als Eintrag in der Datenbank, mit der eindeutigen ID
des USB-Buttons als Primärschlüssel. Ein eingesteckter USB-Button kann dabei präpariert
werden.
• In einem weiteren Programmteil können Zugriffsrechte eingesehen, gesetzt und wieder
entzogen werden. Ein USB-Button kann einen Maker berechtigen, eine oder mehrere
Maschinen zu bedienen.
• Das Log speichert Zugriffe eines USB-Buttons an einer bestimmten Maschine. Die Maschine
wird in der ersten Programmversion simuliert. Dazu kann auf der Programmoberfläche eine
gewünschte Maschine ausgewählt werden. Nach dem Anstecken des USB-Buttons wird die
Zugriffsberechtigung der ID zu der Maschine zusammen mit dem Passwort/PIN geprüft. Ist die
ID berechtigt, wird die Freigabe der Maschine optisch auf der Oberfläche angezeigt, ein
Zeitstempel im Format Datetime generiert und in die Datenbank als Log-Eintrag gespeichert
(Starttime). Ein Abziehen des USB-Buttons beendet die Maschinennutzung und speichert einen
weiteren Zeitstempel (Endtime). Damit ist dieser Log-Vorgang vollständig abgearbeitet.
• Die Gestaltung der Oberfläche geschieht über Windows-Forms mit gängigen Steuerelementen.
Dabei sollen Sie eine benutzerfreundliche und verständliche Oberfläche gestalten. Die Art der
Darstellung ist von der Art der Information abhängig. Verzichten Sie zunächst auf den Einsatz
aufwändiger graphischer Anzeigen zugunsten der Funktionalität.
• Nutzen Sie für alle Datenbankzugriffe die Methoden aus der Klasse Dbase.cs. Optional kann die
Klasse zugunsten einer Optimierung auch angepasst, verbessert und erweitert werden.
