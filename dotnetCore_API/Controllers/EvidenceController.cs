﻿using dotnetCore_API.Models;
using dotnetCore_API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EvidenceController : ControllerBase
    {
        private readonly IEvidenceServices _eviServices;
        private readonly IWebHostEnvironment _environment;
        public EvidenceController(IEvidenceServices eviServices, IWebHostEnvironment environment)
        {
            _eviServices = eviServices;
            _environment = environment;
        }

        [HttpPost]
        [Route("GetEvidence")]
        public IActionResult GetEvidence(EvidenceModel data)
        {
            return Ok( _eviServices.GetEvidence(data.id_leave));
        }
    }
}
