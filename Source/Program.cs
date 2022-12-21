using Raylib_cs;
using keyboard.Source.Code.CLI;

using keyboard.Source.Code;

namespace keyboard;

public static class KeyboardVisualizer
{
    public static Color KeyColor = Color.GRAY;
    public static Color TextColor = Color.RAYWHITE;

    public static void Main(string[] args)
    {
        //* Run once
        CLI_MAIN.CliSize(args);
        Raylib.InitWindow(CLI_MAIN.Width, CLI_MAIN.Height, "Keyboard Visualizer");

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
