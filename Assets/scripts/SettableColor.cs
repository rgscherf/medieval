using UnityEngine;
using UnityEngine.UI;

public enum Paint {
    a,
    b,
    c,
    d,
    e,
    UI,
    background
}

public class SettableColor : MonoBehaviour {

    public Paint paintedColor;
    public float alpha = 1f;

    void Start() {
        ChangeSprite();
        ChangeUIText();
        ChangeUIImage();
    }

    // would this work to parameterize component and color field?
    // void ChangeColor(Component destinationComponent, Color destinationColor) {
    //     GetComponent<destinationComponent>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.destinationColor * new Color(1f, 1f, 1f, alpha);
    // }

    void ChangeUIImage() {
        if (GetComponent<Image>() == null) { return; }
        switch (paintedColor) {
            case Paint.a:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.a * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.b:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.b * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.c:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.c * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.d:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.d * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.e:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.e * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<Image>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }

    void ChangeUIText() {
        if (GetComponent<Text>() == null) { return; }
        switch (paintedColor) {
            case Paint.a:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.a * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.b:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.b * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.c:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.c * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.d:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.d * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.e:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.e * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<Text>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }

    void ChangeSprite() {
        if (GetComponent<SpriteRenderer>() == null) { return; }
        switch (paintedColor) {
            case Paint.a:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.a * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.b:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.b * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.c:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.c * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.d:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.d * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.e:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.e * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.UI:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.UI * new Color(1f, 1f, 1f, alpha);
                break;
            case Paint.background:
                GetComponent<SpriteRenderer>().color = GameObject.Find("Entities").GetComponent<Entities>().palette.background * new Color(1f, 1f, 1f, alpha);
                break;
        }
    }
}

