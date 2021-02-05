using System;

namespace GameProgram
{
    class Program
    {
        static void Main(string[] args)

        {
            Gamer gamer1 = new Gamer() { Id = 1, FirtName = "AYŞENUR", LastName = "ATLAÇ", IdentityNumber = 12345, BirthYear = 2002 };
            Gamer gamer2 = new Gamer() { Id = 2, FirtName = "ALİ", LastName = "ATLAÇ", IdentityNumber = 12346, BirthYear = 1998 };


            GamerManager gamerManager = new GamerManager(new GamerValidationManager());

            gamerManager.Add(gamer2);

            Console.WriteLine("***********************************************************************************************");
            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "Büyük Şubat İndirimi", CampaignDetail = "100TL ve üzeri alışverişlerinizde 20TL indirim" };
            Campaign campaign2 = new Campaign() { CampaignId = 2, CampaignName = "Kış Sonu İndirimi", CampaignDetail = "150TL ve üzeri alışverişlerinizde 30TL indirim" };



            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(new Campaign { CampaignId = 1, CampaignName = "Büyük Şubat İndirimi", CampaignDetail = "100TL ve üzeri alışverişlerinizde 15TL indirim" });

            Console.WriteLine("***********************************************************************************************");
            Game game1 = new Game() { Id = 1, gameName = "GOD OF WAR", gamePrice = 120 };
            Game game2 = new Game() { Id = 2, gameName = "LAST OF US", gamePrice = 350 };
            Game game3 = new Game() { Id = 3, gameName = "RAINBOW SİX SIEGE", gamePrice = 70 };

            OrderManager orderManager = new OrderManager();
            orderManager.Buy(gamer1, game1);
            // OrderManager daki bazı düzenlemeler sayesinde kampanyayı buy metoduna entegre etmeye çalıştım.









        }
    }
}
