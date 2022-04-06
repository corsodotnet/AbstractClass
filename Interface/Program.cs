using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paypal pp = new Paypal();

            IProdottoOnline po = pp;

            po.pagaConID();
            ProdottoFinanziario pf = pp;


            ILettoreMultimediale lettore = new Radio();
            lettore.AlzaVolume();

        }

        public abstract class ProdottoFinanziario
        {
            int dato;
            public abstract ProdottoDigital prodotto { get; set; }
            public abstract void paga(string utente);

        }
        public interface IProdottoOnline
        {

            public void pagaConID();
        }
        public interface IProdottoDigital
        {
            public ProdottoDigital prodotto { get; set; }
            public void pagaConCrypto();
        }
        public class ProdottoDigital
        {

        }

        public class Paypal :
            ProdottoFinanziario,
            IProdottoOnline,
            IProdottoDigital
        {
            public override ProdottoDigital prodotto { get; set; }
            bool isCrypto = true;
            public void pagaConID()
            {
                string email = "bruno@gmail.com";
                paga(email);

            }
            public void pagaConCrypto()
            {
                Console.WriteLine("Pago con crypto");
            }
            public override void paga(string utente)
            {
                //  Effettua pagamento 
            }
        }


        public class IPhone : ILettoreMultimediale
        {
            public void AlzaVolume()
            {

            }
        }
        public class Radio : ILettoreMultimediale
        {
            public void AlzaVolume()
            {

            }
        }
        public class Mp3 : ILettoreMultimediale
        {
            public void AlzaVolume()
            {

            }
        }

        public interface ILettoreMultimediale
        {
            public void AlzaVolume();
        }
    }
}
