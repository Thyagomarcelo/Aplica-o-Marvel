using Marvel_API.Models.Champions;
using Marvel_API.Models.ClassModels;
using System.Collections.Generic;

namespace Marvel_API.Controllers
{
    public interface ICharacterService
    {
        public string saveAllCharactersInBD(string champion);
        List<ChampionFilter> getAllCharacters();
        Champion getChampionDetails(string championId);
    }
}