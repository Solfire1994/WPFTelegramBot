using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTelegramBot.Model
{
    internal class HelpBot
    {

    //    class Bot
    //    {
    //        private MainWindow w;
    //        private TelegramBotClient bot;
    //        public ObservableCollection<MessageLog> BotMessageLog { get; set; }
    //        public CancellationTokenSource cts = new CancellationTokenSource();

    //        public Bot(MainWindow W)
    //        {
    //            //var cts = new CancellationTokenSource();
    //            BotMessageLog = new ObservableCollection<MessageLog>();
    //            this.w = W;
    //            bot = new TelegramBotClient("5644872603:AAG7AMjCt4Mh4iqusMEY20Zyxv34kuBBxqM");
    //            var receiverOptions = new ReceiverOptions
    //            {
    //                AllowedUpdates = { }
    //            };
    //            bot.StartReceiving(HandleUpdatesAsync,
    //                HandleErrorAsync,
    //                receiverOptions,
    //                cancellationToken: cts.Token);
    //            //cts.Cancel();
    //        }
    //        public async Task HandleUpdatesAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    //        {
    //            w.Dispatcher.Invoke((Action)(() =>
    //            {
    //                BotMessageLog.Add(
    //                    new MessageLog(
    //                        (string)DateTime.Now.ToLongTimeString(), update));
    //            }));
    //            await botClient.SendTextMessageAsync(update.Message.Chat.Id,
    //                    text: "Ваше сообщение добавлено в лог");
    //        }

    //        public async void Stop()
    //        {
    //            bot.CloseAsync();
    //            cts.Cancel();
    //        }

    //        Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken cancellationToken)
    //        {
    //            var ErrorMessag = "Ошибка телеграм АПИ:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}";
    //            Console.WriteLine(ErrorMessag);
    //            return Task.CompletedTask;
    //        }
    //    }
    //}




    ////var botClient = new TelegramBotClient("5644872603:AAG7AMjCt4Mh4iqusMEY20Zyxv34kuBBxqM");

    ////using var cts = new CancellationTokenSource();

    ////var receiverOptions = new ReceiverOptions
    ////{
    ////    AllowedUpdates = { }
    ////};
    ////var me = await botClient.GetMeAsync();
    ////// переменная для проверки использования команды загрузки на сервер
    ////bool download = false;
    ////bool upload = false;
    ////bool delete = false;
    ////botClient.StartReceiving
    ////    (HandleUpdatesAsync,
    ////    HandleErrorAsync,
    ////    receiverOptions,
    ////    cancellationToken: cts.Token);
    ////Console.WriteLine($"The @{me.Username} has started");
    ////Console.ReadLine();
    ////cts.Cancel();


    /////// <summary>
    /////// Метод для получения и обработки обновлений внутри бота
    /////// </summary>
    ////async Task HandleUpdatesAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    ////{
    ////    if (update.Type == UpdateType.Message && update.Message != null)
    ////    {
    ////        if (update.Message.Type == MessageType.Text)
    ////        {
    ////            if (upload) await HandleUpdateTextMessage(botClient, update.Message);
    ////            else if (delete) await HandleDeleteTextMessage(botClient, update.Message);
    ////            else await HandleTextMessage(botClient, update.Message);
    ////        }
    ////        else if (download)
    ////        {
    ////            await HandleNotTextMessage(botClient, update, cancellationToken);
    ////        }
    ////        else
    ////        {
    ////            await botClient.SendTextMessageAsync(update.Message.Chat.Id,
    ////            text: "Для загрузки на сервер файла Вам необходимо использовать соответствующую команду");
    ////        }
    ////    }
    ////}

    /////// <summary>
    /////// Метод для обработки текстовых сообщений
    /////// </summary>
    ////async Task HandleTextMessage(ITelegramBotClient botClient, Message message)
    ////{
    ////    if (message.Text == "/start")
    ////    {
    ////        await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Вас приветствует Solfire1994_bot, Вы можете посмотреть список доступных команд /commands");
    ////    }
    ////    else if (message.Text == "/commands")
    ////    {
    ////        await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "\n/description Описание возможностей бота" +
    ////            "\n/seelist Посмотреть список загруженных на сервер файлов" +
    ////            "\n/downloadlist Скачать список загруженных на сервер файлов" +
    ////            "\n/download Загрузить файл с сервера" +
    ////            "\n/upload Загрузить файл на сервер" +
    ////            "\n/delete Удалить файл с сервера" +
    ////            "\n/weather Посмотреть прогноз погоды");
    ////    }
    ////    else if (message.Text == "/description")
    ////    {
    ////        await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Данный бот может сохранять файлы на сервер, позволяет " +
    ////            "их скачивать и удалять, а также может подсказать прогноз погоды :)");
    ////    }
    ////    else
    ////    {
    ////        if (!Directory.Exists(message.From.Id.ToString()))
    ////        {
    ////            Directory.CreateDirectory(message.From.Id.ToString());
    ////        }
    ////        switch (message.Text)
    ////        {
    ////            case "/seelist": await SeeOrDownloadList(botClient, message, true); break;
    ////            case "/downloadlist": await SeeOrDownloadList(botClient, message, false); break;
    ////            case "/download": await DownloadFile(botClient, message); break;
    ////            case "/upload": await UploadFile(botClient, message); break;
    ////            case "/delete": await DeleteFile(botClient, message); break;
    ////            case "/weather": await SeeWeather(botClient, message); break;
    ////            default:
    ////                await botClient.SendTextMessageAsync(message.Chat.Id,
    ////           text: $"Возможно вы ошиблись? Вместо команды вы сказали:\n{message.Text}"); break;
    ////        }
    ////    }
    ////}

    /////// <summary>
    /////// Метод для просмотра либо отправки себе списка загруженных на сервер файлов.
    /////// </summary>
    ////async Task SeeOrDownloadList(ITelegramBotClient botClient, Message message, bool seeOrDownload)
    ////{
    ////    string path = @$"{message.From.Id}\list{message.From.Id}.txt";
    ////    bool isExists = System.IO.File.Exists(@$"{path}");
    ////    if (!isExists)
    ////    {
    ////        await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "У Вас отсутствуют сохраненные на сервере файлы.");
    ////    }
    ////    else
    ////    {
    ////        if (seeOrDownload)
    ////        {
    ////            //see
    ////            using StreamReader sr = new(path);
    ////            string line = sr.ReadLine();
    ////            if (line == null)
    ////            {
    ////                await botClient.SendTextMessageAsync(message.Chat.Id,
    ////                            text: "У Вас отсутствуют сохраненные на сервере файлы.");
    ////            }
    ////            else
    ////            {
    ////                while (line != null)
    ////                {
    ////                    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////                    text: $"{line}");
    ////                    line = sr.ReadLine();
    ////                }
    ////            }
    ////        }
    ////        else
    ////        {
    ////            //download
    ////            await using Stream stream = System.IO.File.OpenRead(@$"{path}");
    ////            await botClient.SendDocumentAsync(
    ////                chatId: message.Chat.Id,
    ////                document: new InputOnlineFile(content: stream, fileName: $"list{message.From.Id}.txt"),
    ////                caption: "Список загрушенных на сервер Вами Файлов");
    ////        }
    ////    }
    ////}

    /////// <summary>
    /////// Метод для загрузки файла на сервер
    /////// </summary>
    ////async Task DownloadFile(ITelegramBotClient botClient, Message message)
    ////{
    ////    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Добавьте в чат файл, который вы хотите сохранить на сервере.");
    ////    download = true;
    ////}

    /////// <summary>
    /////// Метод для обработки не текстовых сообщений
    /////// </summary>
    ////async Task HandleNotTextMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    ////{
    ////    string fileId = update.Message.Type switch
    ////    {
    ////        MessageType.Audio => update.Message.Animation.FileId,
    ////        MessageType.Document => update.Message.Document.FileId,
    ////        MessageType.Photo => update.Message.Photo.Last().FileId,
    ////        MessageType.Video => update.Message.Video.FileId,
    ////        _ => "0",
    ////    };

    ////    if (fileId == "0")
    ////    {
    ////        await botClient.SendTextMessageAsync(update.Message.Chat.Id,
    ////            text: "Данный тип файлов не поддерживается для сохранения ботом");
    ////        return;
    ////    }
    ////    string fileName = update.Message.Type switch
    ////    {
    ////        MessageType.Audio => update.Message.Animation.FileName,
    ////        MessageType.Document => update.Message.Document.FileName,
    ////        MessageType.Video => update.Message.Video.FileName,
    ////        MessageType.Photo => $"photo{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}.jpg",
    ////        _ => "0",
    ////    };
    ////    string firstPartPath = $"{update.Message.From.Id}";
    ////    var file = await botClient.GetFileAsync(fileId, cancellationToken);
    ////    FileStream fs = new FileStream(@$"{firstPartPath}\{fileName}", FileMode.Create);
    ////    await botClient.DownloadFileAsync(file.FilePath, fs, cancellationToken);
    ////    fs.Close();
    ////    fs.Dispose();
    ////    await AddToList($"{update.Message.From.Id}", fileName);
    ////    await botClient.SendTextMessageAsync(update.Message.Chat.Id,
    ////            text: "Запись осуществлена успешно");
    ////    download = false;
    ////}

    /////// <summary>
    /////// Метод по загрузке файла с сервера
    /////// </summary>
    ////async Task UploadFile(ITelegramBotClient botClient, Message message)
    ////{
    ////    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Вы хотите скачать файл? Введите ID необходимого вам файла");
    ////    await SeeOrDownloadList(botClient, message, true);
    ////    string path = @$"{message.From.Id}\list{message.From.Id}.txt";
    ////    if (System.IO.File.Exists(path))
    ////    {
    ////        upload = true;
    ////    }
    ////}

    /////// <summary>
    /////// Метод для обработки текстовых сообщений для отправки фала пользователю
    /////// </summary>
    ////async Task HandleUpdateTextMessage(ITelegramBotClient botClient, Message message)
    ////{
    ////    Dictionary<int, string> list = ReadOfList(message.From.Id.ToString());
    ////    foreach (var item in list)
    ////    {
    ////        if (message.Text == $"{item.Key}")
    ////        {
    ////            string path = @$"{message.From.Id}\{item.Value}";
    ////            await using Stream stream = System.IO.File.OpenRead(@$"{path}");
    ////            await botClient.SendDocumentAsync(
    ////                chatId: message.Chat.Id,
    ////                document: new InputOnlineFile(content: stream, fileName: $"{item.Value}"),
    ////                caption: "Запрошеный вами файл");
    ////            upload = false;
    ////            return;
    ////        }
    ////    }

    ////    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Файл с указанным ID отстутствует");
    ////}

    /////// <summary>
    /////// Метод для удаления файла с сервера
    /////// </summary>
    ////async Task DeleteFile(ITelegramBotClient botClient, Message message)
    ////{
    ////    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Вы хотите удлить файл? Введите ID необходимого вам файла");
    ////    await SeeOrDownloadList(botClient, message, true);
    ////    string path = @$"{message.From.Id}\list{message.From.Id}.txt";
    ////    if (System.IO.File.Exists(path))
    ////    {
    ////        delete = true;
    ////    }
    ////}

    /////// <summary>
    /////// Метод для обработки текстовых сообщений для удаления файла с сервера
    /////// </summary>
    ////async Task HandleDeleteTextMessage(ITelegramBotClient botClient, Message message)
    ////{
    ////    Dictionary<int, string> list = ReadOfList(message.From.Id.ToString());
    ////    foreach (var item in list)
    ////    {
    ////        if (message.Text == $"{item.Key}")
    ////        {
    ////            string path = @$"{message.From.Id}\{item.Value}";
    ////            System.IO.File.Delete(path);
    ////            await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Файл успешно удален");
    ////            delete = false;
    ////            await DeleteFromList(message.From.Id.ToString(), item.Key);
    ////            return;
    ////        }
    ////    }

    ////    await botClient.SendTextMessageAsync(message.Chat.Id,
    ////            text: "Файл с указанным ID отстутствует");
    ////}


    /////// <summary>
    /////// Метод для просмотра прогноза погоды
    /////// </summary>
    ////async Task SeeWeather(ITelegramBotClient botClient, Message message)
    ////{
    ////    // Метод сделал для проверки работы со ссылками с сайтов, для настройки работы АПИ из открытого доступа не хватило терпения)
    ////    Random random = new Random();
    ////    int id = random.Next(1, 5);
    ////    switch (id)
    ////    {
    ////        case 1:
    ////            await botClient.SendTextMessageAsync(message.Chat.Id,
    ////    text: "https://www.accuweather.com/en/kz/karaganda/225167/weather-forecast/225167"); break;
    ////        case 2:
    ////            await botClient.SendTextMessageAsync(message.Chat.Id,
    ////    text: "https://www.accuweather.com/en/ru/petropavlovsk-kamchatsky/288260/weather-forecast/288260"); break;
    ////        case 3:
    ////            await botClient.SendTextMessageAsync(message.Chat.Id,
    ////    text: "https://www.accuweather.com/en/ga/libreville/168271/weather-forecast/168271"); break;
    ////        case 4:
    ////            await botClient.SendTextMessageAsync(message.Chat.Id,
    ////    text: "https://www.accuweather.com/en/by/minsk/28580/weather-forecast/28580"); break;
    ////    }
    ////}

    /////// <summary>
    /////// Метод обработки ошибок
    /////// </summary>
    ////Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken cancellationToken)
    ////{
    ////    var ErrorMessag = exception switch
    ////    {
    ////        ApiRequestException apiRequestException
    ////        => $"Ошибка телеграм АПИ:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}",
    ////        _ => exception.ToString()
    ////    };
    ////    Console.WriteLine(ErrorMessag);
    ////    return Task.CompletedTask;
    ////}

    /////// <summary>
    /////// Метод для добавления в лист нового файла
    /////// </summary>
    ////async Task AddToList(string id, string fileName)
    ////{
    ////    string path = @$"{id}\list{id}.txt";
    ////    int dictId = 0;
    ////    Dictionary<int, string> list = new Dictionary<int, string>();
    ////    if (System.IO.File.Exists(path))
    ////    {
    ////        list = ReadOfList(id);
    ////    }
    ////    using StreamWriter wr = new StreamWriter(path);
    ////    foreach (var element in list)
    ////    {
    ////        wr.WriteLine($"{element.Key}#{element.Value}");
    ////        dictId = element.Key;
    ////    }
    ////    wr.WriteLine($"{dictId + 1}#{fileName}");
    ////    wr.Close();
    ////}

    /////// <summary>
    /////// Метод для удаления из листа файла
    /////// </summary>
    ////async Task DeleteFromList(string id, int fileId)
    ////{
    ////    string path = @$"{id}\list{id}.txt";
    ////    Dictionary<int, string> list = ReadOfList(id);
    ////    using StreamWriter wr = new StreamWriter(path);
    ////    foreach (var element in list)
    ////    {
    ////        if (element.Key != fileId)
    ////        {
    ////            wr.WriteLine($"{element.Key}#{element.Value}");
    ////        }
    ////    }
    ////    wr.Close();
    ////}

    /////// <summary>
    /////// Метод для считывание листа с созраненными файлами
    /////// </summary>
    ////Dictionary<int, string> ReadOfList(string id)
    ////{
    ////    string path = @$"{id}\list{id}.txt";
    ////    using StreamReader sr = new(path);
    ////    string line = sr.ReadLine();
    ////    string[] dictLine = new string[2];
    ////    int dictId;
    ////    Dictionary<int, string> list = new Dictionary<int, string>();
    ////    while (line != null)
    ////    {
    ////        dictLine = line.Split('#', 2);
    ////        dictId = int.Parse(dictLine[0]);
    ////        list.Add(dictId, dictLine[1]);
    ////        line = sr.ReadLine();
    ////    }
    ////    sr.Close();
    ////    return list;
    ////}
}
}
