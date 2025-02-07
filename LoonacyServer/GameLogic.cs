using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.Json;

namespace LoonacyServer
{
    public class GameLogic
    {
        private List<ClientHandler> _players = new List<ClientHandler>();

        private bool _IsStarted = false;

        private static string jsonString = File.ReadAllText("cards.json");
        private List<string> _cardNames = JsonSerializer.Deserialize<List<string>>(jsonString);

        public void ProcessMessage(string message, ClientHandler sender)
        {
            string[] parts = message.Split('|');
            switch (parts[0])
            {
                case "JOIN":
                    string nickname = parts[1];
                    if (_players.Exists(p => p.Nickname == nickname))
                    {
                        sender.SendMessage($"JOIN|ERROR|Nickname already exists.");
                        return;
                    }
                    if (_IsStarted)
                    {
                        sender.SendMessage($"JOIN|ERROR|The game is already started, please wait...");
                        return;
                    }
                    sender.SetNickname(nickname);
                    _players.Add(sender);
                    var koloda = RandomKoloda(_cardNames,7);
                    sender.SendMessage($"JOIN|{nickname}|{koloda}");
                    BroadcastPlayersList();
                    CheckForStartGame();
                    break;
                case "LEAVE":
                    nickname = parts[1];
                    var leavingPlayer = _players.Find(p => p.Nickname == nickname);
                    if (leavingPlayer != null)
                    {
                        _players.Remove(leavingPlayer);
                        BroadcastMessage($"LEAVE|{nickname}");
                        BroadcastPlayersList();
                    }
                    if (_players.Count() == 1 && _IsStarted)
                    {
                        BroadcastMessage($"WIN|{_players[0].Nickname}");
                    }
                    break;
                case "CHAT":
                    nickname = parts[1];
                    string chatMessage = parts[2];
                    BroadcastMessage($"CHAT|{nickname}|{chatMessage}");
                    break;
                case "MOVE":
                    nickname = parts[1];
                    string card = parts[2];
                    string target = parts[3];
                    sender.SendMessage($"MOVE|{nickname}|{card}|{target}");

                    //CheckForWinCondition(koloda_list.Count(), nickname);
                    break;
                case "WIN":
                    nickname = parts[1];
                    sender.SendMessage($"WIN|{nickname}");
                    BroadcastMessage($"WIN|{nickname}");
                    break;
                case "UPDATE":
                    nickname = parts[1];
                    //var kolodaCount = parts[4].Split("&&").ToList().Count();
                    //Console.WriteLine( kolodaCount);
                    Console.WriteLine(parts[4]);

                    BroadcastMessage($"UPDATE|{nickname}|{parts[2]}|{parts[3]}|{parts[4]}|KSBROSA");
                    CheckForWinCondition(parts[4] == "", nickname);
                    break;
            }
        }

        private string RandomKoloda(List<string> cards, int num)
        {
            Random random = new Random();
            List<string> result = new List<string>();
            for (int i = 0; i < num; i++)
            {
                var cardIndex = random.Next(cards.Count);
                var card = cards[cardIndex];
                result.Add(card);
                cards.Remove(cards[cardIndex]);
            }
            return string.Join("&&",result);
        }

        private void BroadcastPlayersList()
        {
            string playersList = string.Join("&&", _players.Select((p, i) => $"{i+1}. {p.Nickname}"));
            Console.WriteLine(playersList);
            BroadcastMessage($"PLAYERS|{playersList}");
        }

        private void CheckForStartGame()
        {
            if (_players.Count == 2)
            {
                _IsStarted = true;
                var kolodaSbrosa = RandomKoloda(_cardNames, 2);
                Console.WriteLine($"START_GAME|{kolodaSbrosa}");
                BroadcastMessage($"START_GAME|{kolodaSbrosa}");
            }
        }

        private void BroadcastMessage(string message)
        {
            foreach (var player in _players)
            {
                player.SendMessage(message);
            }
        }

        private void CheckForWinCondition(bool fl, string nickname)
        {
            // Логика проверки условия победы
            if (fl)
            {
                // Отправить сообщение о победе
                BroadcastMessage($"WIN|{nickname}");
            }
        }

        public void Reset()
        {
            _IsStarted = false;
            _players.Clear();
            _cardNames = JsonSerializer.Deserialize<List<string>>(jsonString);
            Console.WriteLine("Состояние игры сброшено.");
        }



    }
}