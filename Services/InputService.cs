using System;
using Raylib_cs;
using CSE_210_FinalProject.Casting;
using CSE_210_FinalProject.Scripting;

namespace CSE_210_FinalProject.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }

        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }

        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        }
        public bool IsUpPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP);
        }
        public bool IsDownPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN);
        }

        public bool IsMouseLeftClick()
        {
            return Raylib.IsMouseButtonPressed(Raylib_cs.MouseButton.MOUSE_LEFT_BUTTON);
        }
        public bool IsSpacePressed()
        {
            return Raylib.GetKeyPressed() == 32;
        }
        public int GetMouseX()
        {
            return Raylib.GetMouseX();
        }
        public int GetMouseY()
        {
            return Raylib.GetMouseY();
        }

        /// <summary>
        /// Gets the direction asked for by the current key presses
        /// </summary>
        /// <returns></returns>
        public Point GetDirection()
        {
            int x = 0;
            int y = 0;

            if (IsLeftPressed())
            {
                x = -1;
            }

            if (IsRightPressed())
            {
                x = 1;
            }
            
            return new Point(x, y);
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }

        public int MenuControl()
        {
            int direction = 0;

            if (IsUpPressed())
            {
                direction = 1;
            }
            if (IsDownPressed())
            {
                direction = 2;
            }
            if (IsLeftPressed())
            {
                direction = 3;
            }
            if (IsRightPressed())
            {
                direction = 4;
            }

            return direction;
        }
    }

}