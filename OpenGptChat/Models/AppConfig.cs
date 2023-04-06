using CommunityToolkit.Mvvm.ComponentModel;
using OpenGptChat.Common.Models;

namespace OpenGptChat.Models
{
    public partial class AppConfig : ObservableObject
    {
        [ObservableProperty]
        private string _apiHost = "openaiapi.elecho.org";

        [ObservableProperty]
        private string _apiKey = string.Empty;

        [ObservableProperty]
        private string _apiGptModel = "gpt-3.5-turbo";

        [ObservableProperty]
        private int _apiTimeout = 5000;

        [ObservableProperty]
        private double _temerature = 1;

        [ObservableProperty]
        private bool _enableChatContext = true;

        [ObservableProperty]
        private string[] _systemMessages = new string[]
        {

        };

        [ObservableProperty]
        private string _language = string.Empty;

        [ObservableProperty]
        private bool _noProxy = false;

        [ObservableProperty]
        private bool _systemProxy = true;

        [ObservableProperty]
        private bool _proxy = false;

        [ObservableProperty]
        private string _proxyUrl = "http://127.0.0.1:17980";

        [ObservableProperty]
        private ColorMode _colorMode = ColorMode.Auto;

        [ObservableProperty]
        private bool _windowAlwaysOnTop = false;

        [ObservableProperty]
        private string _chatStoragePath = "AppChatStorage.db";
    }
}
