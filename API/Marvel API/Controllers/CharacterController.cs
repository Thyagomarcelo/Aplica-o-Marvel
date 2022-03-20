using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Marvel_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CharacterController : Controller
    {

        private readonly ICharacterService _characterService;
        private readonly ApplicationDbContext _context;

        public CharacterController(ICharacterService characterService,  ApplicationDbContext context)
        {
            _characterService = characterService;
            _context = context;
        }

        [HttpGet]
        public JsonResult saveAllCharactersInBD(string champion)
        {
            string characters = _characterService.saveAllCharactersInBD(champion);

            return Json(new
            {
                data = characters,
                error = false,
            });
        }


        [HttpGet]
        public JsonResult getAllCharacters()
        {

            return Json(new
            {
                data = _characterService.getAllCharacters(),
                error = false,
            });
        }

        [HttpGet]
        public JsonResult getChampionDetails(string championId)
        {


            return Json(new
            {
                Data = _characterService.getChampionDetails(championId),
                Error = false
            });
        }
    }
}
