using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        //private static List<RecordData> Datas = new List<RecordData>
        //{
        //    new RecordData
        //    {
        //        Id = 0,
        //        Date = DateTime.Parse("2023-11-8") ,
        //        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
        //        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
        //        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
        //        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
        //    },
        //    new RecordData
        //    {
        //        Id = 1,
        //        Date = DateTime.Parse("2023-11-9") ,
        //        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
        //        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
        //        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
        //        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")

        //    },
        //    new RecordData
        //    {
        //        Id = 1,
        //        Date = DateTime.Parse("2023-11-10") ,
        //        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
        //        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
        //        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
        //        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
        //    }
        //};


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

    }
}
