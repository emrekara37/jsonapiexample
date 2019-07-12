using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.Extensions.Logging;

namespace JsonApiExample.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PostsController : JsonApiController<Post>
    {

        public PostsController(IJsonApiContext jsonApiContext, IResourceService<Post, int> resourceService, ILoggerFactory loggerFactory) : base(jsonApiContext, resourceService, loggerFactory)
        {
        }
    }
}
