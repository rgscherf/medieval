using UnityEngine;

public interface IPalette {
    // each palette is made of
    // 5 equally weighted colors
    // (randomly assigned to actor
    // body parts)
    // and 2 colors
    // for UI and background

    Color a {get;}
    Color b {get;}
    Color c {get;}
    Color d {get;}
    Color e {get;}
    Color UI {get;}
    Color background {get;}
}

public class Melon : IPalette {
    public static Color _a = RGB.rgb(209, 242, 165);
    public static Color _b = RGB.rgb(239, 250, 180);
    public static Color _c = RGB.rgb(255, 196, 140);
    public static Color _d = RGB.rgb(255, 159, 128);
    public static Color _e = RGB.rgb(245, 105, 145);
    public static Color _UI = RGB.rgb(255, 255, 255);
    public static Color _background = RGB.rgb(20, 20, 20);
    public Color a { get { return _a; } }
    public Color b { get { return _b; } }
    public Color c { get { return _c; } }
    public Color d { get { return _d; } }
    public Color e { get { return _e; } }
    public Color UI { get { return _UI; } }
    public Color background { get { return _background; } }
}

public static class RGB {
    public static Color light = new Color (1.25f, 1.25f, 1.25f, 1);
    public static Color slightdark = new Color (0.9f, 0.9f, 0.9f, 1);
    public static Color dark = new Color (0.75f, 0.75f, 0.75f, 1);
    public static Color vdark = new Color (0.5f, 0.5f, 0.5f, 1);
    public static Color rgb(int r, int g, int b) {
        float cr = r / 256f;
        float cg = g / 256f;
        float cb = b / 256f;
        return new Color(cr, cg, cb, 1);
    }
}