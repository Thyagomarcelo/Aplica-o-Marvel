using Marvel_API.Controllers;
using Marvel_API.Models;
using Marvel_API.Models.Champions;
using Marvel_API.Models.ClassModels;
using Marvel_API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Marvel_API.Services
{
    public class CharacterService : ICharacterService
    {
        private CharacterRepository _repChampion;
       // private CharacterRepository<Champions> _repChampions;
        private readonly ApplicationDbContext dbContext;
        
        public CharacterService(ApplicationDbContext context)
        {
            dbContext = context;
            _repChampion = new CharacterRepository(context);
            //_repChampions = new CharacterRepository<Champions>(context);
        }

        public string saveAllCharactersInBD(string stringChampions)
        {

            var champions = stringChampions.Trim().Split(",");

            foreach(var champion in champions)
            {
                var url = "http://ddragon.leagueoflegends.com/cdn/12.5.1/data/pt_BR/champion/" + Regex.Replace(champion, @"\s", "") + ".json";

                using (var client = new HttpClient())
                {

                    var responseClient = client.GetAsync(url).Result;

                    if (responseClient.IsSuccessStatusCode)
                    {


                        var response = responseClient.Content.ReadAsAsync<ResponseAPIModel>().Result;

                        var championDetails = convertChampionModelToChampionContext(response, Regex.Replace(champion, @"\s", ""));

                        _repChampion.Insert(championDetails);
                        _repChampion.Save();
                    }

                }
            }

            return "success";

        }

        public List<ChampionFilter> getAllCharacters()
        {

            List<ChampionFilter> listChampionsFilter = new List<ChampionFilter>();
            var listChampions = _repChampion.GetAll().ToList();

            foreach(var champion in listChampions)
            {
                ChampionFilter championFilter = convertChampionContextToChampionFilter(champion);
                listChampionsFilter.Add(championFilter);
            }

            return listChampionsFilter;
        }

        public Champion getChampionDetails(string championId)
        {

            Champion championDetails = _repChampion.getById(championId);

            return championDetails;
        }

        private ChampionFilter convertChampionContextToChampionFilter(Champion champion)
        {
            ChampionFilter championFilter = new ChampionFilter();

            championFilter.id = champion.id;
            championFilter.name = champion.name;
            championFilter.title = champion.title;
            championFilter.image = champion.image;

            return championFilter;
        }

        private Champion convertChampionModelToChampionContext(ResponseAPIModel response, string champion)
        {

            ChampionModel championModel = (ChampionModel)response.data.GetType().GetProperty(champion).GetValue(response.data, null);

            Champion championContext = new Champion();
            championContext.allytips = new List<AllyTips>();
            championContext.enemytips = new List<EnemyTips>();
            championContext.tags = new List<Tags>();

            championContext.blurb = championModel.blurb;
            championContext.id = championModel.id;
            championContext.image = championModel.image;
            championContext.info = championModel.info;
            championContext.lore = championModel.lore;
            championContext.name = championModel.name;
            championContext.partype = championModel.partype;
            championContext.passive = championModel.passive;
            championContext.spells = championModel.spells;
            championContext.stats = championModel.stats;
            championContext.title = championModel.title;
            championContext.skins = championModel.skins;

            foreach(var allytip in championModel.allytips)
            {
                AllyTips allytips = new AllyTips();
                
                allytips.description = allytip;

                championContext.allytips.Add(allytips);
            }

            foreach (var allytip in championModel.enemytips)
            {
                EnemyTips enemytips = new EnemyTips();             

                enemytips.description = allytip;

                championContext.enemytips.Add(enemytips);
            }

            foreach (var allytip in championModel.tags)
            {
                Tags tags = new Tags();            

                tags.description = allytip;

                championContext.tags.Add(tags);
            }

            return championContext;
        }
    }
}
