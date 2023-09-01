using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoSettimanale
{
    internal class Contribuente
    { public  string Nome { get; set; }
        public  string Cognome { get; set; }
        public  DateTime DataDiNascita { get; set; }
        public  string CodiceFiscale { get; set; }
        public  string Sesso { get; set; }
        public  string ComuneResidenza {get; set;}
        public double RedditoAnnuale { get; set; }

        public double Imposta;
        public  static List<Contribuente> Lista = new List<Contribuente>();
        public Contribuente() { }

        public Contribuente (string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
        { Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
           CodiceFiscale = codiceFiscale;
            Sesso = sesso;
           ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }
        public static void QualeScegli()
        {
            Console.WriteLine("==========MENU=========");
            Console.WriteLine("Scegli l'operatore da eseguire");
            Console.WriteLine("1-- New contribuente");
            Console.WriteLine("2-- Lista contribuenti");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                MenuC();
            }
            else if (scelta == 2)
            {
                ViewStampa();
            } else { Console.WriteLine("Indica n'altro numero"); }
        }

      

        public static void MenuC()
        {
            Console.WriteLine("Compila i dati anagrafici");

            Console.WriteLine("1-- Inserisci il tuo nome");
            String Nome = Console.ReadLine();

            Console.WriteLine("2-- Inserisci il tuo cognome");
            String Cognome = Console.ReadLine();

            Console.WriteLine("3-- Inserisci la tua data di nascita (gg/mm/aa)");
            DateTime DataDiNascita = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("4-- Inserisci il tuo codice fiscale");
            String CodiceFiscale = Console.ReadLine();

            Console.WriteLine("5-- Sesso");
            String Sesso = Console.ReadLine();

            Console.WriteLine("6-- Inserisici il tuo comune di residenza");
            String ComuneDiResidenza = Console.ReadLine();

            Console.WriteLine("7-- Inserisci il tuo reddito annuale");
            Double RedditoAnnuale = Convert.ToDouble(Console.ReadLine());
            Contribuente contribuente = new Contribuente(Nome,Cognome,DataDiNascita,CodiceFiscale,Sesso,ComuneDiResidenza,RedditoAnnuale);
            if (RedditoAnnuale <= 15000) {
                contribuente.Imposta = RedditoAnnuale * 0.23;
               Lista.Add(contribuente);
                ViewStampa();
                QualeScegli();
            }
           else if (RedditoAnnuale >=15001 && RedditoAnnuale <= 28000)
            {
                contribuente.Imposta = (RedditoAnnuale - 15000) * 0.27 + 3450;
                Contribuente.Lista.Add(contribuente);
                ViewStampa();
                QualeScegli();
            }
            else if (RedditoAnnuale >= 28001 && RedditoAnnuale <= 55000)
            {
                contribuente.Imposta = (RedditoAnnuale - 28000) * 0.38 + 6960;
                Contribuente.Lista.Add(contribuente);
                ViewStampa();
                QualeScegli();
            }
            else if (RedditoAnnuale >= 55001 && RedditoAnnuale <= 75000)
            {
                contribuente.Imposta = (RedditoAnnuale - 55000) * 0.41 + 17220;
                Contribuente.Lista.Add(contribuente);
                ViewStampa();
                QualeScegli();
            }
            else if (RedditoAnnuale >= 75001)
            {
                contribuente.Imposta = (RedditoAnnuale - 75000) * 0.4 + 25420;
                Contribuente.Lista.Add(contribuente);
                ViewStampa();
                QualeScegli();
            }

        } 
        
        public static void ViewStampa()
        {
            Console.WriteLine("Dati");
            foreach(Contribuente x in Lista) { Console.WriteLine( x.Nome, x.Cognome);
                Console.WriteLine(x.DataDiNascita);
                Console.WriteLine(x.CodiceFiscale);
                Console.WriteLine(x.Sesso);
                Console.WriteLine(x.ComuneResidenza);
                Console.WriteLine(x.RedditoAnnuale);
                Console.WriteLine(x.Imposta);
            }
        }
    }
    
    
}
