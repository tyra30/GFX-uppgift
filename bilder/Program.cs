using System;
using Raylib_cs;
using System.Numerics;

namespace bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            float playerX = 20;
            float playerY = 20;

            string gameState = "intro";
            Raylib.InitWindow(800, 600, "Spel");

            Texture2D duckImage = Raylib.LoadTexture("rubbyduccy.png");



            while (!Raylib.WindowShouldClose())
            {

                if (gameState == "intro")
                {

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                    {
                        gameState = "spel";
                    }


                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.BLUE);
                    Raylib.DrawRectangle(300, 300, 200, 100, Color.PINK);
                    Raylib.DrawText("PLAY", 310, 330, 70, Color.PURPLE);
                    Raylib.DrawText("Press E to begin", 280, 430, 30, Color.DARKBLUE);
                    Raylib.EndDrawing();
                }

                else if (gameState == "spel")
                {
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        playerX += 0.1f;
                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        playerX -= 0.1f;
                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        playerY += 0.1f;
                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        playerY -= 0.1f;
                    }

                    if (playerX <= 0)
                    {
                        playerX = 0;
                    }
                    else if (playerX + 70 >= 800)
                    {
                        playerX = 730;
                    }

                    if (playerY <= 0)
                    {
                        playerY = 0;
                    }
                    else if (playerY + 70 >= 600)
                    {
                        playerY = 600 - 70;
                    }


                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.BEIGE);

                    //Raylib.DrawRectangle(700, 100, 70, 50, Color.BLACK);
                    //Raylib.DrawTexture(duckImage, 20, 20, Color.WHITE);

                    Raylib.DrawTextureEx(duckImage, new Vector2(playerX, playerY), 0f, 0.05f, Color.WHITE);

                    Raylib.EndDrawing();
                }
            }
        }
    }
}
