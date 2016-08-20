using UnityEngine;
using UnityEngine.UI;

public enum Paint {
    paletteColor,
    UI,
    background,
    geometryA,
    geometryB,
    geometryC,
    geometryD,
    geometryE,
}

public class SettableColorExpanded : MonoBehaviour {

    public Paint paintedColor;
    Color baseColor;
    public float alpha = 1f;

    void Start() {
        if (paintedColor == Paint.paletteColor) {
            baseColor = GameObject.Find("GameController").GetComponent<Entities>().palette.paletteColor;
        }

        ChangeSprite();
        ChangeUIText();
        ChangeUIImage();
    }

    public void SetColor() {
        Start();
    }

    void ChangeUIImage() {
        if (GetComponent<Image>() == null) { return; }
        switch (paintedColor) {
            case Paint.paletteColor:
                GetComponent<Image>().color = baseColor * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryA:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryA * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryB:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryB * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryC:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryC * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryD:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryD * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryE:
                GetComponent<Image>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryE * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }

    void ChangeUIText() {
        if (GetComponent<Text>() == null) { return; }
        switch (paintedColor) {
            case Paint.paletteColor:
                GetComponent<Text>().color = baseColor * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryA:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryA * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryB:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryB * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryC:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryC * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryD:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryD * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryE:
                GetComponent<Text>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryE * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }

    void ChangeSprite() {
        if (GetComponent<SpriteRenderer>() == null) { return; }
        switch (paintedColor) {
            case Paint.paletteColor:
                GetComponent<SpriteRenderer>().color = baseColor * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryA:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryA * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryB:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryB * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryC:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryC * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryD:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryD * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.geometryE:
                GetComponent<SpriteRenderer>().color = GameObject.Find("GameController").GetComponent<Entities>().palette.geometryE * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }
}

