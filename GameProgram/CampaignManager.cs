using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgram
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi :" + campaign.CampaignName + Environment.NewLine + campaign.CampaignDetail);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya geçerliliği sona erdi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
