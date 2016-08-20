using UnityEngine;
using System.Collections;

public class SnapToGrid : MonoBehaviour {
    public float zpos = 0f;

    // Use this for initialization
    void Start () {
        var x = Mathf.Round(transform.position.x);
        var y = Mathf.Round(transform.position.y);
        transform.position = new Vector3(x, y, zpos);
    }
}
