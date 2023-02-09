using IndigoLabs2.Contract;
using IndigoLabs2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndigoLabs2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSVControllers : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ICSVService _CSVService;
        public CSVControllers(IRepositoryManager repository, ICSVService csvService)
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
            var regionCases = await _CSVService.GetRegionsCases(region, dateFrom, dateTo);
            return Ok(regionCases);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("casesdb")]
        public async Task<IActionResult> GetRegionCasesDB(string region, DateTime dateFrom, DateTime dateTo)
        {
            var regionCases = await _CSVService.GetRegionsCasesDB(region, dateFrom, dateTo);
            return Ok(regionCases);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("lastweek")]
        public async Task<IActionResult> GetRegionLastWeek()
        {
            var lastWeek = await _CSVService.GetRegionLastWeek();
            return Ok(lastWeek);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("lastweekdb")]
        public async Task<IActionResult> GetRegionLastWeekDB()
        {
            var lastWeek = await _CSVService.GetRegionLastWeekDB();
            return Ok(lastWeek);
        }
    }
}
