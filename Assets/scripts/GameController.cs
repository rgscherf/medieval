using UnityEngine;
using System.Collections;

public enum GameState {
    Playing,
    TitleScreen
}

public class GameController : MonoBehaviour {
    Entities entities;
    public GameState gameState;

    float spawnNewActorTimer = 1f;
    float currentNewActorTimer;


    void Awake() {
        entities = GetComponent<Entities>();
        gameState = GameState.Playing;
    }

    // Use this for initialization
    void Start () {
        currentNewActorTimer = 0f;
        // for (var x = 0; x < 10; x++) {
        //     for (var y = 0; y < 10; y++) {
        //         var actor = MakeActor();
        //         actor.transform.position = new Vector3(x, y, -1f);
        //     }
        // }
    }

    void Update() {
        if (gameState == GameState.Playing) {
            var x = Input.GetAxisRaw("Horizontal");
            var y = Input.GetAxisRaw("Vertical");
            const float cameraSpeed = 4f;
            Camera.main.transform.position += new Vector3(x * cameraSpeed * Time.deltaTime, y * cameraSpeed * Time.deltaTime, 0f);
        }

        currentNewActorTimer += Time.deltaTime;
        if (currentNewActorTimer > spawnNewActorTimer &&
                GameObject.FindGameObjectsWithTag("Actor").Length < 200) {
            NewActor();
        }
    }

    void NewActor() {
        var newActor = MakeActor();
        // newActor.AddComponent<ActorController>();
        currentNewActorTimer = 0f;
    }

    GameObject MakeActor() {
        var bodyPrefab = entities.actorBase;
        var go = (GameObject) Instantiate(bodyPrefab, new Vector3(100f, 100f, -1f), Quaternion.identity);
        var selectedSprite = entities.actorSprites[Random.Range(0, entities.actorSprites.Length)];
        go.GetComponent<SpriteRenderer>().sprite = selectedSprite;
        return go;
    }
}
