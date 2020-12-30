# Es.VacanzeNatalizie

Terminata la realizzazione del progetto con l'osservazione di tale problema:
Per realizzare qualcosa di vario (per quanto riguarda gli elementi messi in concorrenza) si notato elementi che necessitano di tempi di elaborazione decisamente minori rispetto
altri, realizzando così un vantaggio netto che porta nel caso specifico alla seguente osservazione:

Il thread N°1 utilizzato per la gestione delle lanterne è sempre più veloce degli altri 2 in quanto deve solo cambiare la source di 5 immagini. Esso arriva sempre 1°.
Il thread N°2 utilizzato per l'aggiornamento della bar è concorrente all'ultimo thread seppur con maggior probabilità di vincita evidenziato da un leggero vantaggio rispetto quest'ultimo.
Il thread N°3 utilizzato per il movimento dell'auto è concorrente al 2° seppur in leggero svantaggio e di conseguenza con probabilità di vincità minori.

Osservazione finale: Il progetto rispetta la consegna che delinea la necessità di mostrare l'esecuzione dei thread in maniera totalmente casuale poichè almeno i thread 2° e 3°
concorrono e i loro risultati evolvono durante diversi debug, il 1° invece subisce sempre un vantaggio tale da permettergli di aggiudicarsi sempre il 1° posto; non per errore nel
codice ma per motivi prima descritti quali operazioni assegnatogli.
