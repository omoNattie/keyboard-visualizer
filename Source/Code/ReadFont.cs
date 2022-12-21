using System;
using Raylib_cs;
using System.Reflection;

namespace keyboard.Source.Code;

public class Fonts
{
    public Font MainFont { get; }

    public Fonts()
    {
        var startupPath = AppDomain.CurrentDomain.BaseDirectory;
        MainFont = Raylib.LoadFont($"{startupPath}/Source/Assets/Fonts/Roboto/RobotoMono-Regular.ttf");
    }
}