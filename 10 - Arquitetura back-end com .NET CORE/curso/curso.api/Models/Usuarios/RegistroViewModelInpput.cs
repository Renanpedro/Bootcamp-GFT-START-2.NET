﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroViewModelInpput : ControllerBase
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }       
    }
}
