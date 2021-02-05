using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgram
{
    class OrderManager : IOrderService
    {
        
        public void Buy(Gamer gamer, Game game)
        {
            if (game.gamePrice>=100 && game.gamePrice<150)
            {
                game.gamePrice = game.gamePrice - 20;
                Console.WriteLine ("Büyük Şubat İndirimi ----> -20TL");
                Console.WriteLine("İndirimli fiyat:" + game.gamePrice);
                Console.WriteLine(gamer.FirtName + " , " + game.gameName + " satın aldınız. Keyifle oynamanız dileğiyle !");
            }

            else if (game.gamePrice>=150)
            {
                game.gamePrice = game.gamePrice - 30;
                Console.WriteLine("Kış Sonu İndirimi ----> -30TL");
                Console.WriteLine("İndirimli fiyat:" + game.gamePrice);
                Console.WriteLine(gamer.FirtName + " , " + game.gameName + " satın aldınız. Keyifle oynamanız dileğiyle !");


            }
            
        }

        
    }
}
