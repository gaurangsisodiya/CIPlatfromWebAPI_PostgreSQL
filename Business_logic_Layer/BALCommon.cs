using Data_Access_Layer;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_Layer
{
    public class BALCommon
    {
        private readonly DALCommon _dALCommon;

        public BALCommon(DALCommon dALCommon)
        {
            _dALCommon = dALCommon;
        }

        public async Task<List<Country>> GetCountryListAsync()
        {
            return await _dALCommon.GetCountrylListAsync();
        }
        public async Task<List<City>> GetCityByCountryIdAsync(int id)
        {
            return await _dALCommon.GetCityByCountryIdAsync(id);
        }
    }
}
