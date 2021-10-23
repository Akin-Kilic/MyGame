using Business.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game { Id = 1, Name = "Assassin's Creed Valhalla", Price = 250 };
            Game game2 = new Game { Id = 2, Name = "Valorant ", Price = 20 };

            Player player1 = new Player { Id = 1, FirstName = "Akın", LastName = "KILIÇ", BirthYear = 2000, IdentificationNumber = "123456789" };
            Player player2 = new Player { Id = 2, FirstName = "Muharrem", LastName = "CANDAN", BirthYear = 2001, IdentificationNumber = "987654321" };

            Campaign campaign = new Campaign { Id = 1, Name = "Black Friday", Discount = 35 };


            GameManager gameManger = new GameManager();
            gameManger.Add(game);
            gameManger.Add(game2);
            gameManger.Delete(game2);
            gameManger.Update(game);


            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Delete(player2);
            playerManager.Update(player1);


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
        }   
    }
}
