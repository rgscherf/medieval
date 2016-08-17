using UnityEngine;

public class Entities : MonoBehaviour {
    public IPalette palette;

    void Awake() {
        palette = new Melon();
    }


}
