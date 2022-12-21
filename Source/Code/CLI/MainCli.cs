namespace keyboard.Source.Code.CLI;

public static class CLI_MAIN
{
    public static string? PATH;

    public static int Width = 300;
    public static int Height = 200;

    public static void CliSize(string[] args)
    {
        string Version = "Version 0.3 Build Release 1 - BETA";

        string HelpString = """
            Description:
                Visualizes the keyboard based on your settings.

            Usage: keyboard [flags]
            Example: keyboard --path ~/game.json --resolution default

            Flags:
                --help          Show this help message and exit.
                --version       Show the version of the program.
                --path          Path to the json file to use as the layout.
                --resolution    Set the resolution for the window. Only usable after --path.
                    default     Command for -r to set the resolution to 300x200

            Aliases:
                -h --help
                -v --version
                -p --path
                -r --resolution

            Run:
                "keyboard --path ~/Path/To/Proj/Source/Data/sample.json --resolution default" to run your first keyboard
        """;
        switch(args[0])
        {
            case "-p":
            case "--path":
                if(args.Length < 3)
                {
                    Console.WriteLine("Missing arguments! Please refer to keyboard --help");
                    Environment.Exit(1);
                }

                PATH = args[1];
                if(args[2] == "-r" || args[2] == "--resolution")
                {
                    if(args[3] == "default")
                    {
                        Console.WriteLine("Using default resolution configuration.");
                    return;
                    }


                    if(int.TryParse(args[3], out Width) && int.TryParse(args[4], out Height))
                    {
                        Console.WriteLine($"Resolution chosen: {Width}x{Height}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid resolution: {args[3]}x{args[4]}\n" +
                        "Either one or both arguments are wrong, please use ints or refer to Keyboard --help. Using default configs.");
                        
                        Width = 300;
                        Height = 200;
                    }
                }
            break;
            
            case "-h":
            case "--help":
                Console.WriteLine(HelpString);
                Environment.Exit(0);
            break;

            case "-v":
            case "--version":
                Console.WriteLine(Version);
            break;
        }
    }
}