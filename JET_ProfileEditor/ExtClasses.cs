using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace JET_ProfileEditor
{
    public class Profile
    {
        public ProfileCharacter characters { get; set; }
        public string[] suits { get; set; }
    }

    public class ProfileCharacter
    {
        public Character pmc { get; set; }
    }

    public class BackupFile
    {
        public string Path { get; set; }
        public DateTime date { get; set; }
    }

    public class AccentItem
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Scheme { get; set; }
    }

    public class GlobalLang
    {
        [JsonProperty("interface")]
        public Dictionary<string, string> Interface { get; set; }

        [JsonProperty("trading")]
        public Dictionary<string, TraderLocale> Traders { get; set; }

        [JsonProperty("quest")]
        public Dictionary<string, QuestLocale> Quests { get; set; }

        [JsonProperty("templates")]
        public Dictionary<string, Template> Templates { get; set; }
    }

    public class Template
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }

    public class TraderLocale
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }

    public class QuestLocale
    {
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class SkillInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public int progress { get; set; }

        public int Max { get; set; }
    }

    public class CharacterHideoutArea
    {
        public int type { get; set; }
        public string name { get; set; }
        public int MaxLevel { get; set; }
        public int CurrentLevel { get; set; }

        public Dictionary<string, JToken> stages { get; set; }
    }

    public class AreaInfo
    {
        public int type { get; set; }
        public Dictionary<string, JToken> stages { get; set; }
    }

    public class TraderInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public int CurrentLevel { get; set; }
        public bool Display { get; set; }
        public List<LoyaltyLevel> Levels { get; set; }
    }

    public class LoyaltyLevel
    {
        public int level { get; set; }
        public long SalesSum { get; set; }
        public float Standing { get; set; }
    }

    public class Quest
    {
        public string qid { get; set; }
        public string trader { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }

    public class CharacterInventory
    {
        public int Rubles { get; set; }
        public int Euros { get; set; }
        public int Dollars { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
    }

    public class InventoryItem
    {
        public string id { get; set; }
        public string name { get; set; }

        public string tpl { get; set; }
    }

    public class QuestData
    {
        public string _id { get; set; }
        public string traderId { get; set; }
    }

    public class ExaminedItem
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Item
    {
        [JsonProperty("_id")]
        public string id { get; set; }

        [JsonProperty("_name")]
        public string name { get; set; }

        [JsonProperty("_props")]
        public ItemProps props { get; set; }

        [JsonProperty("_parent")]
        public string parent { get; set; }

        [JsonProperty("_type")]
        public string type { get; set; }
    }

    public class ItemProps
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int StackMaxSize { get; set; }
        public int ExtraSizeLeft { get; set; }
        public int ExtraSizeRight { get; set; }
        public int ExtraSizeUp { get; set; }
        public int ExtraSizeDown { get; set; }
        public Grid[] Grids { get; set; }
        public bool Foldable { get; set; }
        public string FoldedSlot { get; set; }
        public int SizeReduceRight { get; set; }
        public bool ExtraSizeForceAdd { get; set; }
        public bool ExaminedByDefault { get; set; }
        public bool QuestItem { get; set; }
    }

    public class Grid
    {
        [JsonProperty("_props")]
        public GridProps gridProps { get; set; }
    }

    public class GridProps
    {
        public int cellsH { get; set; } //10
        public int cellsV { get; set; } //68
    }

    public class ServerGlobals
    {
        //moved the Global Declaration to the Data Class -Fenex
        public Data data { get; set; }
    }

    //basicly a dirty fix adding compatibility for the "data" json node right before the "config" json node -Fenex
    //"HealthEffect" and "ItemPreset" related stuff might not work in the profile editor since the json path changed -Fenex
    public class Data
    {
        public Global config { get; set; }
    }

    public class Global
    {
        public Mastering[] Mastering { get; set; }
    }

    public class Mastering
    {
        public string Name { get; set; }
        public string[] Templates { get; set; }
        public int Level3 { get; set; }
    }

    public class SuitInfo
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public bool Bought { get; set; }
    }

    public class TraderSuit
    {
        public string _id { get; set; }
        public string suiteId { get; set; }
    }
}
