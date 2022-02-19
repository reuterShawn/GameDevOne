using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    [SerializeField] private Transform mainTransform;
    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            mainTransform.position += mainTransform.up * moveSpeed;

        } else if (Input.GetKey(downKey)) {
            mainTransform.position += mainTransform.up * moveSpeed;

        }
    }
}
