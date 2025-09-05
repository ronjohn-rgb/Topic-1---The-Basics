using System.ComponentModel;

namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Assignment");
            //Number 1
            Console.WriteLine("Number 1.");
            // a.
            string firstName, favMovie, smallGreeting;
            // b.
            firstName = "Aron";
            favMovie = "THE MATRIX";
            smallGreeting = $"Hello, my name is {firstName} and my favourite movie is {favMovie}";
            // c.
            Console.WriteLine(smallGreeting);
            Console.WriteLine(smallGreeting.Contains("THE"));
            // d.
            Console.WriteLine(favMovie);
            favMovie = favMovie.Replace("THE", "TH3");
            favMovie = favMovie.Replace("MATRIX", "M@TRIX");
            Console.WriteLine(favMovie);

            Console.WriteLine();
            Console.WriteLine();

            //Number 2
            Console.WriteLine("Number 2.");
            string movieQuote;
            movieQuote = "Go ahead, make my day";
            Console.WriteLine($"Original quote: \"{movieQuote}\"");
            Console.WriteLine($"Changed quote: \"{movieQuote.Replace('o', ' ').Replace('a', ' ').Replace('e', ' ')}\"");

            Console.WriteLine();
            Console.WriteLine();

            //Number 3
            Console.WriteLine("Number 3.");
            Console.WriteLine();
            // a.
            Console.WriteLine(" ________________________\r\n|.----------------------.|\r\n||                      ||\r\n||                      ||\r\n||     .-\"````\"-.       ||\r\n||    /  _.._    `\\     ||\r\n||   / /`    `-.   ; . .||\r\n||   | |__  __  \\   |   ||\r\n||.-.| | e`/e`  |   |   ||\r\n||   | |  |     |   |'--||\r\n||   | |  '-    |   |   ||\r\n||   |  \\ --'  /|   |   ||\r\n||   |   `;---'\\|   |   ||\r\n||   |    |     |   |   ||\r\n||   |  .-'     |   |   ||\r\n||'--|/`        |   |--.||\r\n||   ;    .     ;  _.\\  ||\r\n||    `-.;_    /.-'     ||\r\n||         ````         ||\r\n||jgs___________________||\r\n'------------------------'");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                              /^\\\r\n           L L               /   \\               L L\r\n        __/|/|_             /  .  \\             _|\\|\\__\r\n       /_| [_[_\\           /     .-\\           /_]_] |_\\\r\n      /__\\  __`-\\_____    /    .    \\    _____/-`__  /__\\\r\n     /___] /=@>  _   {>  /-.         \\  <}   _  <@=\\ [___\\\r\n    /____/     /` `--/  /      .      \\  \\--` `\\     \\____\\\r\n   /____/  \\____/`-._> /               \\ <_.-`\\____/  \\____\\\r\n  /____/    /__/      /-._     .   _.-  \\      \\__\\    \\____\\\r\n /____/    /__/      /         .         \\      \\__\\    \\____\\\r\n|____/_  _/__/      /          .          \\      \\__\\_  _\\____|\r\n \\__/_ ``_|_/      /      -._  .        _.-\\      \\_|_`` _\\___/\r\n   /__`-`__\\      <_         `-;        NDT_>      /__`-`__\\\r\n      `-`           `-._       ;       _.-`           `-`\r\n                        `-._   ;   _.-`\r\n                            `-._.-`");
        }
    }
}
