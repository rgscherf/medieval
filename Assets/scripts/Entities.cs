using UnityEngine;

public class Entities : MonoBehaviour {
    public IPaletteExpanded palette;

    public GameObject actorBase;
    public Sprite[] actorSprites;
    // public GameObject[] actorBodies;
    // public GameObject[] actorHeadDecorations;
    // public GameObject[] actorCarryDecorations;
    public Sprite[] wallTiles;

    public GameObject[] navPoints;
    public GameObject[] entryPoints;

    void Awake() {
        palette = new Pastel();
    }


}
