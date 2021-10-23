using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CampaignManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi: "+campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi: "+campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi: "+campaign.Name);
        }
    }
}
