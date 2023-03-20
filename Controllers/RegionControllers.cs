using IndigoLabs2.Contract;
using IndigoLabs2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndigoLabs2.Controllers
{
    [Route("api/region")]
    [ApiController]
    public class RegionControllers : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ICSVService _CSVService;
        public RegionControllers(IRepositoryManager repository, ICSVService csvService)
        {
            _repository = repository;
            _CSVService = csvService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("cases")]
        public async Task<IActionResult> GetRegionCases(string region, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var regionCases = await _CSVService.GetRegionsCases(region, dateFrom, dateTo);
                return Ok(regionCases);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("casesdb")]
        public async Task<IActionResult> GetRegionCasesDB(string region, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var regionCases = await _CSVService.GetRegionsCasesDB(region, dateFrom, dateTo);
                return Ok(regionCases);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("lastweek")]
        public async Task<IActionResult> GetRegionLastWeek()
        {
            try
            {
                var lastWeek = await _CSVService.GetRegionLastWeek();
                return Ok(lastWeek);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType (StatusCodes.Status418ImATeapot)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("lastweekdb")]
        public async Task<IActionResult> GetRegionLastWeekDB()
        {
            try
            {
                var lastWeek = await _CSVService.GetRegionLastWeekDB();
                return Ok(lastWeek);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);    
            }
        }
    }
}
