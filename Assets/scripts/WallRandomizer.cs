using UnityEngine;

public class WallRandomizer : MonoBehaviour {

    // Use this for initialization
    void Start () {
        var wallTiles = GameObject.Find("GameController").GetComponent<Entities>().wallTiles;
        var tile = wallTiles[Random.Range(0, wallTiles.Length)];
        GetComponent<SpriteRenderer>().sprite = tile;
    }

}
