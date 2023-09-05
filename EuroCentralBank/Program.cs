using System;

namespace EuroCentralBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CountryDeathPunishment palestina = new CountryDeathPunishment("palestina");
            EuropeanCourtOfHumanRights sc = new EuropeanCourtOfHumanRights();
            Console.WriteLine($"Nome Stato: {palestina.Name}");
            sc.JudgeCountry(palestina);
            EuroZoneCountry italy = new EuroZoneCountry("italia");
            Console.WriteLine($"Nome Stato: {italy.Name}");
            sc.JudgeCountry(italy);
            Console.WriteLine($"Valuta dell'Italia: { italy.Coin}");
            Console.WriteLine($"spread italia: {EuroCentralBank.ApplySpread(italy)}");
            











            //EuroCentralBank centralBank = new EuroCentralBank();
            //Paese italy = new Paese
            //{
            //    Name = "Italia",
            //    IsEurozoneMember = true,
            //    IsEUMember = true,
            //    DeathPenalty = PenaDiMorteEnum.Abolished,

            //};
            //centralBank.AddEurozoneCountry(italy);

            //Paese usa = new Paese
            //{
            //    Name = "USA",
            //    IsEurozoneMember = false,
            //    IsEUMember = false,
            //    DeathPenalty = PenaDiMorteEnum.Retained,

            //};


            //Paese moldavia = new Paese
            //{
            //    Name = "Moldavia",
            //    IsEurozoneMember = false,
            //    IsEUMember = true,
            //    DeathPenalty = PenaDiMorteEnum.Abolished,

            //};


            //EuropeanCourtOfHumanRights court = new EuropeanCourtOfHumanRights();


            //Console.WriteLine(court.CheckHumanRightsCompliance(italy));
            //Console.WriteLine("Spread fittizio: " + centralBank.GenerateRandomSpread(0.0, 7.0));
            //Console.WriteLine(court.CheckHumanRightsCompliance(usa));
            //Console.WriteLine("Spread fittizio: " + centralBank.GenerateRandomSpread(0.0, 7.0));
            //Console.WriteLine(court.CheckHumanRightsCompliance(moldavia));
            //Console.WriteLine("Spread fittizio: " + centralBank.GenerateRandomSpread(0.0, 7.0));



        }
    }
    
}
