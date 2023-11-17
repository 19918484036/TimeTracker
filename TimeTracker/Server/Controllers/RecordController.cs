using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        
        private readonly IRecordService _recordService;

        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<RecordData>>>> GetRecords()
        {
            var result = await _recordService.GetRecordsAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<int>>> PostRecordsAsync(RecordData recordData)
        {
            var response = await _recordService.PostRecordsAsync(recordData);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
