﻿using Repository.Models;
using System.Collections.Generic;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositeries.ContentRepositories
{
    public interface IContentRepository
    {
        IEnumerable<Caption> GetCaptions();
        IEnumerable<PortfolioPhoto> GetPortfolioPhotos();
        IEnumerable<PortfolioLevel> GetPortfolioLevels();
        IEnumerable<EECart> GetEduCarts();
        IEnumerable<EECart> GetexpCarts();
        IEnumerable<Service> GetServices();
        IEnumerable<Service> GetService();
        IEnumerable<SkillValue> GetSkils();
        IEnumerable<SkillValue> GetSkill();
        IEnumerable<Caption> GetCaption();

        public  Info GetInfos();

    }
}

