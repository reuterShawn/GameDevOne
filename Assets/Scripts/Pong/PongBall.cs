using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidbody;
    [SerializeField] private float startSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    public void Restart()
    {
        mainRigidbody.position = new Vector2(0.0f, 2.0f);
        mainRigidbody.velocity = new Vector2(0.0f, 2.0f);
        StartCoroutine(randomPosition());
    }

    IEnumerator randomPosition() {
        yield return new WaitForSeconds(1);
        Vector2 newVelocity = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 1f));
        mainRigidbody.velocity = newVelocity.normalized * startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

