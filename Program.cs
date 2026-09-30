using System;
using Raylib_cs;
using System.Numerics;
Console.WriteLine("Hello, World!");

Raylib.InitWindow(800, 600, "Linea");
Raylib.SetTargetFPS(60);
while (!Raylib.WindowShouldClose())
{
    //borra la pantalla y la pinta de color negro
    Raylib.BeginDrawing();
    Raylib.ClearBackground(new Color(255, 255, 255, 255));
    int x1 = 8, y1 = 2, x2 = 8, y2 = 12;
    //dibuja una linea desde el centro de la ventana hasta la posicion del mouse
    DrawLineDDA(x1*10, y1*10, x2*10, y2*10, new Color(0, 0, 255, 255));
    Raylib.EndDrawing();
}

static void DrawLineDDA(int x1, int y1, int x2, int y2, Color color)
{
    int dx = x2 - x1;
    int dy = y2 - y1;
    int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
    if (steps == 0) { Raylib.DrawPixel(x1, y1, color); return; }

    float x = x1, y = y1;
    float xInc = dx / (float)steps;
    float yInc = dy / (float)steps;
    for (int i = 0; i <= steps; i++) {
        Raylib.DrawPixel((int)MathF.Round(x), (int)MathF.Round(y), color);
        x += xInc; y += yInc;
    }
}

