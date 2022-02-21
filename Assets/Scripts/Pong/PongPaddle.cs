using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    [SerializeField] private Transform mainTransform;
    [SerializeField] private float moveSpeed;
    private float position = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float minY = 0;
        float maxY = 4;
        float posY = mainTransform.position.y;
        
        if (Input.GetKey(upKey) && posY > minY - moveSpeed && posY < maxY){
            mainTransform.Translate(0, moveSpeed, 0);
        } if (Input.GetKey(downKey) && posY > minY && posY < maxY + moveSpeed) {
            mainTransform.Translate(0, -moveSpeed, 0);
        }
    }
}
