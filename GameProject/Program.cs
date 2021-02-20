using GameProject.Adaptor;
using GameProject.Concreate;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.FirstName = "Sevcan";
            gamer1.LastName = "Özdemir";
            gamer1.NationalityId = "12345678910";
            gamer1.DateOfBirth = new DateTime(2021, 01, 01);

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 2;
            gamer2.FirstName = "Esmecan";
            gamer2.LastName = "Özdemir";
            gamer2.NationalityId = "12345678901";
            gamer2.DateOfBirth = new DateTime(2020, 01, 01);

            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer1);

            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            gamerManager2.Add(gamer2);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Oyun1";
            game1.GamePrice = 100;

            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "Oyun2";
            game2.GamePrice =200;

            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            gameManager1.Add(game2);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Kampanya1";
            campaign1.DiscountRate = 10;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Kampanya2";
            campaign2.DiscountRate = 15;

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            campaignManager1.Add(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer1);
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(game1, gamer1, campaign1);
            salesManager.CampaignSales(game2, gamer1, campaign2);


            gamerManager1.Update(gamer1);

            gamerManager1.Delete(gamer1);
       

           
            gameManager1.Update(game1);
            gameManager1.Update(game2);
            gameManager1.Delete(game1);
            gameManager1.Delete(game2);
         
            campaignManager1.Update(campaign1);
            campaignManager1.Update(campaign2);
            campaignManager1.Delete(campaign1);
            campaignManager1.Delete(campaign2);

        }
    }
}
