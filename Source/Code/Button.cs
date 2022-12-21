using System.Numerics;
using Raylib_cs;

namespace keyboard.Source.Code;

public class Button
{
    private readonly int _posX;
    private readonly int _posY;

    private readonly string? _text;
    private readonly int _textLen;
    
    private readonly int _buttonHeight;
    private readonly int _buttonWidth;

    private readonly KeyboardKey _key;

    public Button(int posX, int posY, string text, int textLen, int buttonHeight, int buttonWidth, KeyboardKey key)
    {
        this._posX = posX;
        this._posY = posY;
        this._text = text;
        this._textLen = textLen;
        this._buttonHeight = buttonHeight;
        this._buttonWidth = buttonWidth;
        this._key = key;
    }

    private int CalculateX() => _posX + _buttonWidth / 2 - (5 * _textLen);
    private int CalculateY() => _posY + _buttonHeight / 2 - 10;

    public void AddButton()
    {
        Raylib.DrawRectangle(_posX, _posY, _buttonWidth, _buttonHeight, Raylib.IsKeyDown(_key) ? Color.WHITE : Color.GRAY);
        
        var pos = new Vector2(CalculateX(), CalculateY());
        Raylib.DrawTextEx(KeyboardVisualizer.Roboto.MainFont, _text, pos, 20, 1, Color.BLACK);
    }
}