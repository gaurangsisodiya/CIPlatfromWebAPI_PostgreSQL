using Business_logic_Layer;
using Data_Access_Layer;
using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly BALCommon _bALCommon;

        public CommonController(BALCommon bALCommon)
        {
            _bALCommon = bALCommon;
        }

        [HttpGet]
        [Route("CountryList")]
        public async Task<ActionResult<ResponseResult>> GetCountryList()
        {
            try
            {
                var result = await _bALCommon.GetCountryListAsync();
                return Ok(new ResponseResult { Data = result, Result = ResponseStatus.Success });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseResult { Result = ResponseStatus.Error, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("CityList/{id}")]
        public async Task<ActionResult<ResponseResult>> GetCityByCountryId(int id)
        {
            try
            {
                var result = await _bALCommon.GetCityByCountryIdAsync(id);
                return Ok(new ResponseResult { Data = result, Result = ResponseStatus.Success });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseResult { Result = ResponseStatus.Error, Message = ex.Message });
            }
        }
    }
}
