using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası eklendi" );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ "kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası güncellendi");
        }
    }
}
