﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class GeneralSettingsManager : GenericService<GeneralSettings>
    {
        IGeneralSettingsRepository _generalSettings;
        public GeneralSettingsManager(IGeneralSettingsRepository generalSettings)
        {
            _generalSettings = generalSettings;
        }

        public void Add(GeneralSettings p)
        {
            _generalSettings.Add(p);
        }

        public void Delete(GeneralSettings p)
        {
            _generalSettings.Delete(p);
        }

        public GeneralSettings GetById(int id)
        {
            return _generalSettings.GetById(id);
        }

        public List<GeneralSettings> List()
        {
            return _generalSettings.List();
        }

        public List<GeneralSettings> List(Expression<Func<GeneralSettings, bool>> filter)
        {
            return _generalSettings.List(filter);
        }

        public void Update(GeneralSettings p)
        {
            _generalSettings.Update(p);
        }
    }
}
