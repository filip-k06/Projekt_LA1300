# Lern-Bericht

Kritzner, Bytyqi, Sacher, Tuma, JW

## Einleitung
Wir haben ein Spiel wie Hangman programmiert.

## Was haben wir gelernt?
Wir haben vieles gelernt aber vor allem hat uns das Abspielen eines Sounds fasziniert.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Beschreibung
Wir können nun beliebige Sounds in C# abspielen. In unserem Programm hört man Sounds, wenn man Punkte bekommt oder verliert. Dies scheint am Anfang kompliziert zu sein, ist es allerdings nicht wirklich. Anhand des Codes unten sieht man, wie man einen Sound mithilfe dem `SoundPlayer` abspielen kann. Zuerst muss man aber die Bibliothek `System` importieren, dass man den `SoundPlayer` verwenden kann. Bei meinem Code habe ich eine extra Funktion für das Abspielen eines Sounds erstellt. Man kann aber auch direkt im `Main` die Sounds abspielen. In der Funktion habe ich als Erstes den Pfad der Sound Datei definiert. Die Sound Datei muss zwingend eine `.wav` Datei sein. Dabei darf die Datei beliebig lang sein. Am Schluss muss man nur noch die `.Play` Funktion Callen um den Sound abzuspielen. Wichtig ist noch zu wissen, dass das Programm genug lange laufen muss, um den Sound ganz abspielen zu können. Deswegen habe ich einen `Thread.Sleep(5000)` eingefügt damit der ganze Sound abgespielt werden kann.

**Code-Beispiel:**

![image](https://user-images.githubusercontent.com/110892683/208464774-0e155b94-faaa-412b-9ad9-40352bbc2a95.png)

**Video**
https://user-images.githubusercontent.com/110892683/208615495-5af60d3c-3d83-426e-86b0-a65cebf3534c.mp4

## Verifikation
**Textbeschreibung:** Dient zur Verständnis des Codes.<br>
**Code-Beispiel:** Zeigt wie man Sounds abspielt.<br>
**Video:** Zeigt das der Code funktioniert.<br>

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Reflexion zum Arbeitsprozess

Wir konnten uns dank dem Online-Unterricht besser konzentrieren und fokussieren, darum konnten wir viele Fehler finden und beheben.

Unsere Team-Arbeit war allerdings am Anfang vor allem im Online-Unterricht nicht so gut, weil niemand wusste was die anderen gerade machten. Wir konnten dies aber lösen indem wir mehr über Teams und WhatsApp kommuniziert haben.

**VBV:** Ein Verbesserungsvorschlag wäre, dass wir nach jeder Sitzung ein Teams-Meeting machen, wo jeder seine Fortschritte den anderen zeigen würde. So würden immer alle wissen wer was gemacht hat.

