using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Statistiche
{
    public class Statistiche
    {

        int sommaValori;
        int numeroValori;
        int sommaValoriPerPeso;
        double sommaPesi;
        int mediaAritmetica;
        double mediaPonderata;
        int cont;


        public Statistiche()
        {

        }

        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        {

            sommaValori = sommaValori + valore;
            numeroValori++;
            cont++;

        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            sommaValoriPerPeso = sommaValoriPerPeso + valore;
            sommaPesi = sommaPesi + peso;
            cont++;
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            mediaAritmetica = sommaValori / numeroValori;
            return mediaAritmetica;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            mediaPonderata = sommaValoriPerPeso / sommaPesi;
            return mediaPonderata;
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {
            sommaValori = 0;
            numeroValori = 0;
            sommaValoriPerPeso = 0 ;
            sommaPesi = 0;
            mediaAritmetica = 0;
            mediaPonderata = 0;
            cont = 0;
        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {
            return cont;
        }

    }
}
