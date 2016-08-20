using UnityEngine;

public interface IPaletteExpanded {
    // each palette is made of
    // 5 equally weighted colors
    // (randomly assigned to actor
    // body parts)
    // and 2 colors
    // for UI and background
    Color paletteColor {get;}
    Color UI {get;}
    Color background {get;}
    Color geometryA {get;}
    Color geometryB {get;}
    Color geometryC {get;}
    Color geometryD {get;}
    Color geometryE {get;}
}

public class Pastel : IPaletteExpanded {
    static Color[] _bodyColors = {
        RGB.rgb(137, 140, 255),
        RGB.rgb(255, 137, 181),
        RGB.rgb(255, 220, 137),
        RGB.rgb(144, 212, 247),
        RGB.rgb(113, 224, 150),
        RGB.rgb(245, 162, 111),
        RGB.rgb(237, 109, 121),
        RGB.rgb(90, 208, 229),
        RGB.rgb(207, 243, 129),
        RGB.rgb(255, 150, 227),
        RGB.rgb(187, 150, 255),
        RGB.rgb(103, 238, 189)
    };
    static Color _UI = RGB.rgb(251, 236, 233);
    static Color _background = RGB.rgb(14, 13, 90);
    static Color _geometryA = RGB.rgb(255, 225, 163);
    static Color _geometryB = RGB.rgb(255, 180, 149);
    static Color _geometryC = RGB.rgb(214, 98, 168);
    static Color _geometryD = RGB.rgb(106, 45, 138);
    static Color _geometryE = RGB.rgb(65, 42, 120);

    public Color paletteColor {get {return _bodyColors[Random.Range(0, _bodyColors.Length)];}}
    public Color UI { get { return _UI; } }
    public Color background { get { return _background; } }
    public Color geometryA {get {return _geometryA; } }
    public Color geometryB {get {return _geometryB; } }
    public Color geometryC {get {return _geometryC; } }
    public Color geometryD {get {return _geometryD; } }
    public Color geometryE {get {return _geometryE; } }

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