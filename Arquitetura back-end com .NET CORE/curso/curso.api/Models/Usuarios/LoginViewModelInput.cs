using Microsoft.AspNetCore.Http;
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
    public class LoginViewModelInput

    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }


        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

    }
}
