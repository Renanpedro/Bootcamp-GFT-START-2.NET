using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curso.api.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErroGenericoViewModel : ControllerBase
    {
        public string Mensagem {get; set;}
    }
}
