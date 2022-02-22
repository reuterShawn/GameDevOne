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
        mainRigidbody.position = Vector2.zero;
        mainRigidbody.velocity = Vector2.zero;
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


// // We had issues calling the coroutine from a static method.
// // While not ideal, for now we worked around this using
// // https://forum.unity.com/threads/c-coroutines-in-static-functions.134546/
// public class runCoroutine : MonoBehaviour 
// {
//     [SerializeField] private static Rigidbody2D mainRigidbody;
//     [SerializeField] private float startSpeed;

//     static public runCoroutine coroutine;
    
//     void Awake()
//     {
//     coroutine = this;
//     }
    
//     IEnumerator doCoroutine() {
//         yield return new WaitForSeconds(1);
//         Vector2 newVelocity = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 1f));
//         mainRigidbody.velocity = newVelocity.normalized * startSpeed;
//     }
    
//     static public void randomDirection() {
//         coroutine.StartCoroutine("doCoroutine");
//     }
// }
