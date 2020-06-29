using Blazor.FMEA.Api.Models.Forms;
using Blazor.FMEA.Shared.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.Api.Controllers.Forms
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetectionMethodController : ControllerBase
    {
        private readonly IDetectionMethodRepository _detectionMethodRepository;

        public DetectionMethodController(IDetectionMethodRepository detectionMethodRepository)
        {
            this._detectionMethodRepository = detectionMethodRepository;
        }

        [HttpGet]
        public IActionResult GetAllDetectionMethodRecords()
        {
            return Ok(this._detectionMethodRepository.GetAll().ToArray());
        }

        [HttpGet("{DetectionId}")]
        public IActionResult GetDetectionMethodRecordById(int DetectionId)
        {
            return Ok(this._detectionMethodRepository.GetAll().Where(res => res.Detection_ID == DetectionId).FirstOrDefault());
        }
    }
}
