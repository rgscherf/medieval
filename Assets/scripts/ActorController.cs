using UnityEngine;
using System.Collections.Generic;

public class ActorController : MonoBehaviour {

    PolyNavAgent agent;
    public Queue<GameObject> navPoints;
    Entities entities;
    bool exitingMap;
    float waitTimeMin = 1f;
    float waitTimeMax = 3f;

    float speedMin = 1.5f;
    float speedMax = 3f;

    void Start () {
        transform.SetParent(GameObject.Find("Actors").transform);

        entities = GameObject.Find("GameController").GetComponent<Entities>();
        transform.position = entities.entryPoints[Random.Range(0, entities.entryPoints.Length)].transform.position;
        var possibleNavs = entities.navPoints;

        navPoints = new Queue<GameObject>();
        int numOfNavs = Random.Range(3, 8);
        for (int i = 0; i < numOfNavs; i++) {
            var randomNav = possibleNavs[Random.Range(0, possibleNavs.Length)];
            navPoints.Enqueue(randomNav);
        }


        agent = GetComponent<PolyNavAgent>();
        agent.OnDestinationReached += WaitAtDestination;

        agent.maxSpeed = Random.Range(speedMin, speedMax);

        var firstDestination = navPoints.Peek().transform.position;
        agent.SetDestination(firstDestination);


    }

    void WaitAtDestination() {
        if (exitingMap) {
            Object.Destroy(gameObject);
        } else {
            float waitTime = Random.Range(waitTimeMin, waitTimeMax);
            Invoke("NextDestination", waitTime);
        }
    }


    void NextDestination() {
        Debug.Log("Destination reached!");
        navPoints.Dequeue();
        Vector3 newDestination;
        if (navPoints.Count == 0) {
            exitingMap = true;
            newDestination = entities.entryPoints[Random.Range(0, entities.entryPoints.Length)].transform.position;
        } else {
            newDestination = navPoints.Peek().transform.position;
        }
        agent.SetDestination(newDestination);
    }
}
