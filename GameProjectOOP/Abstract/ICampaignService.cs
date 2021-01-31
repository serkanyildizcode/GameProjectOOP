using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campagain);
        void Update(Campaign campagain);
        void Delete(Campaign campagain);

    }
}
