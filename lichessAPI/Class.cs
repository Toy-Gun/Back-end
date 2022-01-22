using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject1
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Chess960
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Atomic
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class RacingKings
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class UltraBullet
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Blitz
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class KingOfTheHill
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Bullet
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Correspondence
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Horde
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Puzzle
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Classical
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Rapid
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Storm
    {
        public int runs { get; set; }
        public int score { get; set; }
    }

    public class Perfs
    {
        public Chess960 chess960 { get; set; }
        public Atomic atomic { get; set; }
        public RacingKings racingKings { get; set; }
        public UltraBullet ultraBullet { get; set; }
        public Blitz blitz { get; set; }
        public KingOfTheHill kingOfTheHill { get; set; }
        public Bullet bullet { get; set; }
        public Correspondence correspondence { get; set; }
        public Horde horde { get; set; }
        public Puzzle puzzle { get; set; }
        public Classical classical { get; set; }
        public Rapid rapid { get; set; }
        public Storm storm { get; set; }
    }

    public class Profile
    {
        public string country { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int fideRating { get; set; }
        public int uscfRating { get; set; }
        public int ecfRating { get; set; }
        public string links { get; set; }
    }

    public class PlayTime
    {
        public int total { get; set; }
        public int tv { get; set; }
    }

    public class Count
    {
        public int all { get; set; }
        public int rated { get; set; }
        public int ai { get; set; }
        public int draw { get; set; }
        public int drawH { get; set; }
        public int loss { get; set; }
        public int lossH { get; set; }
        public int win { get; set; }
        public int winH { get; set; }
        public int bookmark { get; set; }
        public int playing { get; set; }
        public int import { get; set; }
        public int me { get; set; }
    }

    public class Account
    {
        public string id { get; set; }
        public string username { get; set; }
        public bool online { get; set; }
        public Perfs perfs { get; set; }
        public long createdAt { get; set; }
        public bool disabled { get; set; }
        public bool tosViolation { get; set; }
        public Profile profile { get; set; }
        public long seenAt { get; set; }
        public bool patron { get; set; }
        public bool verified { get; set; }
        public PlayTime playTime { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string playing { get; set; }
        public int completionRate { get; set; }
        public Count count { get; set; }
        public bool streaming { get; set; }
        public bool followable { get; set; }
        public bool following { get; set; }
        public bool blocking { get; set; }
        public bool followsYou { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Variant
    {
        public string key { get; set; }
        public string name { get; set; }
        public string @short { get; set; }
    }

    public class Opponent
    {
        public string id { get; set; }
        public string username { get; set; }
        public int rating { get; set; }
    }

    public class NowPlaying
    {
        public string fullId { get; set; }
        public string gameId { get; set; }
        public string fen { get; set; }
        public string color { get; set; }
        public string lastMove { get; set; }
        public Variant variant { get; set; }
        public string speed { get; set; }
        public string perf { get; set; }
        public bool rated { get; set; }
        public Opponent opponent { get; set; }
        public bool isMyTurn { get; set; }
    }

    public class AccountPlaying
    {
        public List<NowPlaying> nowPlaying { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Variant2
    {
        public string key { get; set; }
        public string name { get; set; }
        public string @short { get; set; }
    }

    public class Clock
    {
        public int initial { get; set; }
        public int increment { get; set; }
    }

    public class Perf
    {
        public string name { get; set; }
    }

    public class White
    {
        public string id { get; set; }
        public string name { get; set; }
        public object title { get; set; }
        public int rating { get; set; }
        public bool provisional { get; set; }
    }

    public class Black
    {
        public string id { get; set; }
        public string name { get; set; }
        public object title { get; set; }
        public int rating { get; set; }
        public bool provisional { get; set; }
    }

    public class State
    {
        public string type { get; set; }
        public string moves { get; set; }
        public int wtime { get; set; }
        public int btime { get; set; }
        public int winc { get; set; }
        public int binc { get; set; }
        public string status { get; set; }
    }

    public class GameFull
    {
        public string id { get; set; }
        public Variant2 variant { get; set; }
        public Clock clock { get; set; }
        public string speed { get; set; }
        public Perf perf { get; set; }
        public bool rated { get; set; }
        public long createdAt { get; set; }
        public White white { get; set; }
        public Black black { get; set; }
        public string initialFen { get; set; }
        public string type { get; set; }
        public State state { get; set; }
    }

    public class GameState
    {
        public string type { get; set; }
        public string moves { get; set; }
        public int wtime { get; set; }
        public int btime { get; set; }
        public int winc { get; set; }
        public int binc { get; set; }
        public string status { get; set; }
        public string winner { get; set; }
    }

    public class ChatLine
    {
        public string type { get; set; }
        public string username { get; set; }
        public string text { get; set; }
        public string room { get; set; }
    }

}
