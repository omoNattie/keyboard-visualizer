using System.Reflection;
using Raylib_cs;
using keyboard.Source.Code.CLI;

using keyboard.Source.Code;

namespace keyboard.Source;

public static class KeyboardVisualizer
{
    public static readonly Fonts Roboto = new();
    public static void Main(string[] args)
    {
        //* Run once
        CLI_MAIN.CliSize(args);

        Raylib.InitWindow(CLI_MAIN.Width, CLI_MAIN.Height, "Keyboard Visualizer");
        Raylib.SetTargetFPS(60);
        
        var startupPath = AppDomain.CurrentDomain.BaseDirectory;
        var icon = Raylib.LoadImage($"{startupPath}/Source/Assets/Images/A.png");
        Raylib.SetWindowIcon(icon);

        while (!Raylib.WindowShouldClose())
        {
            //* Update
            
            //* Draw 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLUE);

            Keys.AddKeys();
 
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
