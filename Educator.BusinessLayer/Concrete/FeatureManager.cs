﻿using Educator.BusinessLayer.Abstract;
using Educator.DataAccessLayer.Abstract;
using Educator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educator.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TInsert(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
