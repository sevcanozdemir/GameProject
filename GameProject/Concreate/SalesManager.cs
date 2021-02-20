using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class SalesManager : ISalesManager

    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int hesap = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.DiscountRate + " indirimle " + hesap + " TL'ye satın aldı." );

        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " oyununu " + game.GamePrice + " TL'ye satın aldı.");
        }
    }
}
