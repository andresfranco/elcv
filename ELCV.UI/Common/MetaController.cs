﻿using ELCV.Core.Common;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ELCV.UI.WebApi.Common
{
    public class MetaController : BaseApiController

    {
        public MetaController( ApiControllerErrorHandler errorHandler):base(errorHandler)
        {

        }
        [HttpGet("/info")]
        public ActionResult<string> Info()
        {
            var assembly = typeof(Startup).Assembly;

            var creationDate = System.IO.File.GetCreationTime(assembly.Location);
            var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

            return Ok($"Version: {version}, Last Updated: {creationDate}");
        }
    }
}
