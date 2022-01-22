using System;
using System.Net;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace CsProject1
{

    class Program
    {
        const string userInfoURI = "https://lichess.org/api/account";
        const string userGameInfoURI = "https://lichess.org/api/board/game/stream/";
        const string userOngoingGame = "https://lichess.org/api/account/playing";
        static WebHeaderCollection OAuth2 = new WebHeaderCollection();

        static Account Account = new Account();
        static AccountPlaying accountPlaying = new AccountPlaying();
        static readonly HttpClient client = new HttpClient();


        static Task Main(string[] args)
        {
            OAuth2.Set("Authorization", "Bearer lip_2HAxNSCyraaKzc3DX5Ro");

            Console.WriteLine("logging in lichess......");

            GetUserInfo();

            Console.WriteLine("Done.\n");

            Console.WriteLine("Account: " + Account.username);


            string gameID = "";
            Console.WriteLine("\nGetting Game ID......");

            for (; ; )
            {
                GetOngoingGame();
                if (accountPlaying.nowPlaying.Count > 0)
                {
                    foreach (NowPlaying element in accountPlaying.nowPlaying)
                    {
                        gameID = element.gameId;
                    }
                }
                if (gameID != "")
                {
                    Console.WriteLine("Done.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Not found.");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("Game ID: " + gameID);

            Console.WriteLine("\nFinding Game......");

            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(userGameInfoURI + gameID);
            myrequest.Headers.Add(OAuth2);

            StreamReader rqt = new StreamReader(myrequest.GetResponse().GetResponseStream(), Encoding.UTF8);
            string json = rqt.ReadLine();
            //Console.WriteLine(json);
            GameFull gameStream = JsonSerializer.Deserialize<GameFull>(json);

            Console.WriteLine("Done.");
            // Console.WriteLine("\nGame Created At: " + gameStream.createdAt);
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            double date = gameStream.createdAt / 1000;
            DateTime dt = startTime.AddSeconds(date);
            Console.WriteLine("\nGame Created At: " + dt.ToString("yyyy/MM/dd HH:mm:ss"));

            Console.WriteLine("\nstates: " + gameStream.state.moves + "\n\n");
            for (; ; )
            {
                string _json = rqt.ReadLine();

                if (_json == null || _json == "")
                    continue;

                var _gameState = JsonSerializer.Deserialize<GameState>(_json);
                var _chatLine = JsonSerializer.Deserialize<ChatLine>(_json);
                string moves = _gameState.moves;
                string text = _chatLine.text;
                string winner = _gameState.winner;

                if (!string.IsNullOrEmpty(moves))
                    Console.WriteLine("state: " + moves.Substring(moves.Length - 4));

                if (!string.IsNullOrEmpty(winner))
                {
                    Console.WriteLine("winner: " + _gameState.winner);
                    break;
                }
                if (!string.IsNullOrEmpty(text))
                    Console.WriteLine("\n" + _chatLine.username + ": " + text);
                Console.WriteLine("\n");
            }


            Thread.Sleep(5000);
            return Task.CompletedTask;
        }

        static void GetOngoingGame()
        {
            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(userOngoingGame);
            myrequest.Headers.Add(OAuth2);

            StreamReader rqt = new StreamReader(myrequest.GetResponse().GetResponseStream(), Encoding.UTF8);
            string rqtJson = rqt.ReadToEnd();
            //   Console.WriteLine(rqtJson);

            accountPlaying = JsonSerializer.Deserialize<AccountPlaying>(rqtJson);

        }
        static void GetUserInfo()
        {
            HttpWebRequest myrequest = (HttpWebRequest)WebRequest.Create(userInfoURI);
            myrequest.Headers.Add(OAuth2);

            StreamReader rqt = new StreamReader(myrequest.GetResponse().GetResponseStream(), Encoding.UTF8);
            string rqtJson = rqt.ReadToEnd();
            // Console.WriteLine(rqtJson);

            Account = JsonSerializer.Deserialize<Account>(rqtJson);

        }

    }
}
