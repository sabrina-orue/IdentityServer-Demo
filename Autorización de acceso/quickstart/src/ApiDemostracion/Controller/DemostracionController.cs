using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemostracion.Controller
{
    [Authorize]
    public class DemostracionController
    {
        [Route("Animales")]
        [HttpGet]
        public IActionResult GetAnimals()
        {
            return new JsonResult("Perro, Gato, Pato");
        }


        [Route("Personas")]
        [HttpGet]
        public IActionResult GetPerson()
        {
            return new JsonResult("Claudia, Rosa, Julia");
        }

    }
}
