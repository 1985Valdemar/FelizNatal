using System;
using System.IO;
using System.Media;
using System.Threading;

class Program
{
    static ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Magenta };

    static string[] messages =
    {
        "Feliz Natal",
        "Que seu Natal",
        "seja muito abençoado",
        "com a paz de Cristo"

    };

    static void DisplayMessage()
    {
        int colorIndex = 0;
        const string border = "***********************";

        while (true)
        {
            Console.Clear();

            foreach (var message in messages)
            {
                Console.ForegroundColor = colors[colorIndex];
                Console.WriteLine($"{border} {message} {border}");
                colorIndex = (colorIndex + 1) % colors.Length;
                Thread.Sleep(500); // Animação por linha
            }
        }
    }

    static void Main(string[] args)
    {
        string musicPath = "Music\\MusicaNatal.wav";

        try
        {
            if (File.Exists(musicPath))
            {
                using (SoundPlayer player = new SoundPlayer(musicPath))
                {
                    player.PlayLooping(); // Tocar música em loop
                    DisplayMessage();     // Mostrar mensagem com animação
                }
            }
            else
            {
                Console.WriteLine($"Erro: Arquivo de música não encontrado em '{musicPath}'");
                DisplayMessage(); // Apenas exibe a mensagem sem música
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
