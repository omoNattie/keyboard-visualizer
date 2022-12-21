using System.IO;
using Newtonsoft.Json.Linq;
using keyboard.Source.Code.CLI;
using Raylib_cs;

namespace keyboard.Source.Code;

public static class Keys
{
    public static void AddKeys()
    {
        if(CLI_MAIN.PATH == null)
            return;

        // get the json array from the specified file
        dynamic jsonObj = JArray.Parse(File.ReadAllText(CLI_MAIN.PATH));

        foreach (var json in jsonObj)
        {
            int posx = json.px;
            int posy = json.py;

            string name = json.name;
            var nameLen = name.Length;

            int buttonWidth = json.ButtonWidth;
            int buttonHeight = json.ButtonHeight;

            KeyboardKey key = json.keycode;

            var button = new Button(posx, posy, name, nameLen, buttonHeight, buttonWidth, key);
            button.AddButton();
        }

    }
}