﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonServerAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase,IServer
    {
        [HttpGet]
        public string Ping()
        {
            return "Initialized";
        }

        [HttpPost]
        public Response Execute(Request request)
        {
            return new Response();
        }
    }
}