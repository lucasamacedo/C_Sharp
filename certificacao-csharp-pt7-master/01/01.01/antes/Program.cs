using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.Tocar();

        }
    }

    class Campainha
    {
        public Action OnCampainhaTocou { get; set; }
        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou();
            }
        }
    }
}
