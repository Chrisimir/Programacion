using System;
using Tao.Sdl;

namespace Centipede
{
    /**
      * This class will manage every hardware issue: screen resolution, keyboard input and some other aspects
      */
    class Hardware
    {
        public static int KEY_ESC = Sdl.SDLK_ESCAPE;
        public static int KEY_UP = Sdl.SDLK_UP;
        public static int KEY_DOWN = Sdl.SDLK_DOWN;
        public static int KEY_LEFT = Sdl.SDLK_LEFT;
        public static int KEY_RIGHT = Sdl.SDLK_RIGHT;
        public static int KEY_SPACE = Sdl.SDLK_SPACE;

        short screenWidth;
        short screenHeight;
        short colorDepth;
        IntPtr screen;

        public Hardware(short width, short height, short depth, bool fullScreen)
        {
            screenWidth = width;
            screenHeight = height;
            colorDepth = depth;

            int flags = Sdl.SDL_HWSURFACE | Sdl.SDL_DOUBLEBUF | Sdl.SDL_ANYFORMAT;
            if (fullScreen)
                flags = flags | Sdl.SDL_FULLSCREEN;

            Sdl.SDL_Init(Sdl.SDL_INIT_EVERYTHING);
            screen = Sdl.SDL_SetVideoMode(screenWidth, screenHeight, colorDepth, flags);
            Sdl.SDL_Rect rect = new Sdl.SDL_Rect(0, 0, screenWidth, screenHeight);
            Sdl.SDL_SetClipRect(screen, ref rect);
            SdlTtf.TTF_Init();
        }

        ~Hardware()
        {
            Sdl.SDL_Quit();
        }

        public void DrawImage(Image img)
        {
            Sdl.SDL_Rect source = new Sdl.SDL_Rect(0, 0, img.GetImageWidth(), img.GetImageHeight());
            Sdl.SDL_Rect target = new Sdl.SDL_Rect(img.GetX(), img.GetY(), img.GetImageWidth(), img.GetImageHeight());
            Sdl.SDL_BlitSurface(img.GetImage(), ref source, screen, ref target);
        }

        public void WriteText(string text, short x, short y, byte r, byte g, byte b,
            Font fontType)
        {
            Sdl.SDL_Color color = new Sdl.SDL_Color(r, g, b);
            IntPtr textAsImage = SdlTtf.TTF_RenderText_Solid(fontType.GetFontType(),
            text, color);
            if (textAsImage == IntPtr.Zero)
                Environment.Exit(5);
            Sdl.SDL_Rect src = new Sdl.SDL_Rect(0, 0, screenWidth, screenHeight);
            Sdl.SDL_Rect dest = new Sdl.SDL_Rect(x, y, screenWidth, screenHeight);
            Sdl.SDL_BlitSurface(textAsImage, ref src, screen, ref dest);
        }

        public int KeyPressed()
        {
            int pressed = -1;

            Sdl.SDL_PumpEvents();
            Sdl.SDL_Event keyEvent;
            if (Sdl.SDL_PollEvent(out keyEvent) == 1)
            {
                if (keyEvent.type == Sdl.SDL_KEYDOWN)
                {
                    pressed = keyEvent.key.keysym.sym;
                }
            }

            return pressed;
        }

        public bool IsKeyPressed(int key)
        {
            bool pressed = false;
            Sdl.SDL_PumpEvents();
            Sdl.SDL_Event evt;
            Sdl.SDL_PollEvent(out evt);
            int numKeys;
            byte[] keys = Sdl.SDL_GetKeyState(out numKeys);
            if (keys[key] == 1)
                pressed = true;
            return pressed;
        }

        public void UpdateScreen()
        {
            Sdl.SDL_Flip(screen);
        }

        public void ClearScreen()
        {
            Sdl.SDL_Rect source = new Sdl.SDL_Rect(0, 0, screenWidth, screenHeight);
            Sdl.SDL_FillRect(screen, ref source, 0);
        }
    }
}
