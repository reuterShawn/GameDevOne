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
        StartCoroutine(Restart());
        IEnumerator Restart()
        {
            mainRigidbody.position = Vector2.zero;
            mainRigidbody.velocity = Vector2.zero;

            Vector2 newVelocity = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 1f));
            mainRigidbody.velocity = newVelocity.normalized * startSpeed;
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
