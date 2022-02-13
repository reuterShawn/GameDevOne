using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private AudioSource audioSource;

    private float lastHitTime = 0;

    public void SetColor(Color colorObject)
    {
        meshRenderer.material.SetColor("_Color", colorObject);
    }

    private void OnCollisionEnter(Collision collision) {
        
        if((Time.time - lastHitTime) > 0.25f){
            lastHitTime = Time.time;
            audioSource.volume = Mathf.InverseLerp(0,10, collision.relativeVelocity.magnitude);
            audioSource.pitch = Random.Range(0.75f, 1.25f);
            audioSource.Play();
        }
        
    }
}
