using SibadishnikBotForTG.Entities;
using SibadishnikBotForTG.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace SibadishnikBotForTG.Bot
{
    public static class Sibadishnik
    {
        private static TelegramBotClient _client;
        private static bool _muted = true;
        private static bool _working = false;

        static Sibadishnik()
        {
            string token = "here_must_be_token_of_your_bot";
            _client = new TelegramBotClient(token);
        }

        public static void Start()
        {
            _working = true;
            _client.StartReceiving();
            Unmute();
        }

        public static void Stop()
        {
            _working = false;
            _client.StopReceiving();
            if (!_muted)
                Mute();
        }

        public static void Unmute()
        {
            _client.OnMessage += OnMessageHandler;
            _client.OnMessage -= OnMessageHandlerQuiet;
            _muted = false;
        }

        public static void Mute()
        {
            _client.OnMessage -= OnMessageHandler;
            _client.OnMessage += OnMessageHandlerQuiet;
            _muted = true;
        }

        public static bool IsMuted() => _muted;
        public static bool IsWorking() => _working;

        public static async void SendMessage(long chatId, string message)
        {
            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);
            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );
        }

        public static async void SendDocument(long chatId, InputOnlineFile linkToFile)
        {
            string message = "\"Документ\"";

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendDocumentAsync(chatId, document: "https://sibadi.org/upload/priem_2022/bulleten_2022_bak_mag.pdf");

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                message,
                botMessage.Date,
                false
                );
        }

        private static void OnMessageHandler(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == null)
                return;

            OnMessageHandlerQuiet(sender, e);

            var text = e.Message.Text;
            var chatId = e.Message.Chat.Id;

            if (text.Equals("/start") | text.Equals("Старт"))
                ActStart(chatId);

            else if (text.Equals("Буклет приёмной комиссии"))
                ActBooklet(chatId);

            else if (text.Equals("Университет"))
                ActTextFromMain(chatId, @"..\..\Docs\СибАДИ.txt");

            else if (text.Equals("Факультеты"))
                ActFaculties(chatId);

            else if (text.Equals("Военный Учебный Центр\n(ранее Военная Кафедра)"))
                ActTextFromMain(chatId, @"..\..\Docs\ВУЦ.txt");

            else if (text.Equals("Общежитие"))
                ActTextFromMain(chatId, @"..\..\Docs\Общежитие.txt");

            else if (text.Equals("Стипендия"))
                ActTextFromMain(chatId, @"..\..\Docs\Стипендия.txt");

            else if (text.Equals("Сроки и испытания"))
                ActTerms(chatId);

            else if (text.Equals("Подписаться на события") | text.Equals("Отписаться от событий"))
                ActSubscription(chatId);

            else if (text.Equals("Автомобильные дороги\nи мосты"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\АДМ.txt");

            else if (text.Equals("Автомобильный транспорт"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\АТ.txt");

            else if (text.Equals("Заочный факультет"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\ЗФ.txt");

            else if (text.Equals("Информационные системы\nв управлении"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\ИСУ.txt");

            else if (text.Equals("Нефтегазовая и строительная\nтехника"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\НСТ.txt");

            else if (text.Equals("Промышленное и гражданское\nстроительство"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\ПГС.txt");

            else if (text.Equals("Экономика и управление"))
                ActTextFromFaculties(chatId, @"..\..\Docs\Faculties\ЭиУ.txt");

            else if (text.Equals("Контрольные цифры"))
                ActTextFromTerms(chatId, @"..\..\Docs\Terms\Бюджет.txt");

            else if (text.Equals("Договор"))
                ActTextFromTerms(chatId, @"..\..\Docs\Terms\Платно.txt");

            else if (text.Equals("Назад"))
                ActMain(chatId);

            else
                ActZero(chatId);
        }

        private static void OnMessageHandlerQuiet(object sender, MessageEventArgs e)
        {
            if (e.Message.Text == null)
                return;

            SaveData(
                e.Message.Chat.Id,
                e.Message.Chat.Username,
                e.Message.Chat.FirstName,
                e.Message.Chat.LastName,
                e.Message.Text,
                e.Message.Date,
                true
                );
        }

        private static async void ActStart(long chatId)
        {
            string message = "Здравствуй!\nЯ - бот СибАДИ. Меня зовут СибАДИшник!\n" +
                "Я помогу тебе познакомиться с университетом!";

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActMain(chatId);
        }

        private static async void ActMain(long chatId)
        {
            string textForSubscription;
            if (PersonRepo.GetPersonById(chatId).IsSubscribed())
                textForSubscription = "Отписаться от событий";
            else
                textForSubscription = "Подписаться на события";

            string message = "Выбери интересующий вариант среди клавиш внизу";

            var buttons = new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton { Text = "Буклет приёмной комиссии"} },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Университет" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Факультеты" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Военный Учебный Центр\n(ранее Военная Кафедра)" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Общежитие" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Стипендия" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Сроки и испытания" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = textForSubscription } }
                }
            };

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message, replyMarkup: buttons);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );
        }

        private static async void ActBooklet(long chatId)
        {
            string link = "https://sibadi.org/upload/priem_2022/bulleten_2022_bak_mag.pdf";
            string message = "\"Документ\"";

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendDocumentAsync(chatId, document: link);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                message,
                botMessage.Date,
                false
                );

            ActMain(chatId);
        }

        private static async void ActTextFromMain(long chatId, string path)
        {
            string message = GetTextFromFile(path);

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActMain(chatId);
        }

        private static async void ActFaculties(long chatId)
        {
            string message = "Про какой факультет хочешь узнать?";

            var buttons = new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton { Text = "Автомобильные дороги\nи мосты" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Автомобильный транспорт" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Заочный факультет" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Информационные системы\nв управлении" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Нефтегазовая и строительная\nтехника" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Промышленное и гражданское\nстроительство" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Экономика и управление" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Назад" } }
                }
            };

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message, replyMarkup: buttons);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );
        }

        private static async void ActTerms(long chatId)
        {
            string message = "В рамках контрольных цифр или по договорам об оказании платных образовательных услуг?";

            var buttons = new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton { Text = "Контрольные цифры" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Договор" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "Назад" } }
                }
            };

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message, replyMarkup: buttons);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );
        }

        private static async void ActSubscription(long chatId)
        {
            PersonRepo.GetPersonById(chatId).ChangeSubscrided();
            string message;
            if (PersonRepo.GetPersonById(chatId).IsSubscribed())
                message = "Вы подписались на события СибАДИ";
            else
                message = "Вы отписались от событий СибАДИ";

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActMain(chatId);
        }

        private static async void ActTextFromFaculties(long chatId, string path)
        {
            string message = GetTextFromFile(path);

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActFaculties(chatId);
        }

        private static async void ActTextFromTerms(long chatId, string path)
        {
            string message = GetTextFromFile(path);

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActTerms(chatId);
        }

        private static async void ActZero(long chatId)
        {
            string message = "Не понимаю. Давай начнём сначала)";

            var me = await _client.GetMeAsync();
            var botMessage = await _client.SendTextMessageAsync(chatId, message);

            SaveData(
                me.Id,
                me.Username,
                me.FirstName,
                me.LastName,
                botMessage.Text,
                botMessage.Date,
                false
                );

            ActStart(chatId);
        }

        private static void SaveData(
            long id,
            string username,
            string firstName,
            string lastName,
            string text,
            DateTime date,
            bool isSent
            )
        {
            var person = PersonRepo.GetPersonById(id);
            if (person == null)
            {
                person = new Person(
                    id,
                    username,
                    firstName,
                    lastName
                    );
                PersonRepo.Add(person);
            }

            var notice = new Notice(
                text,
                date
                );
            if (isSent)
                person.AddSentNotice(notice);
            else
                person.AddReceivedNotice(notice);

            HistoryRepo.Add(new History(
                person, notice
                ));
        }

        private static string GetTextFromFile(string path)
        {
            string text;
            try
            {
                var streamReader = new StreamReader(path);
                text = streamReader.ReadToEnd();
            }
            catch
            {
                text = "Ошибочка...";
            }
            return text;
        }
    }
}