using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCD_ColorFull
{
    public enum color
    {
        none = -1,
        NEGRO = 0,
        DARK_AZUL = 1,
        DARK_VERDE = 2,
        DARK_CYAN = 3,
        DARK_ROJO = 4,
        DARK_MAGENTA = 5,
        DARK_AMARILLO = 6,
        GRIS = 7,
        DARK_GRIS = 8,
        AZUL = 9,
        VERDE = 10,
        CYAN = 11,
        ROJO = 12,
        MAGENTA = 13,
        AMARILLO = 14,
        BLANCO = 15
    };
    public class COLOR
    {
        public static void ColorText(color foretext, color backtext)
        {
            if (backtext != color.none)
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(color), backtext.ToString());
            }
            if (foretext != color.none)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(color), foretext.ToString());
            }
        }
        public static void ColorFondo(color fondo)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(color), fondo.ToString());
            Console.Clear();
            Console.ResetColor();
        }
    }
}
