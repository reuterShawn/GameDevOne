using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform gunTransform;
    [SerializeField] private Transform shootPosition;

    [SerializeField] private float rotationSpeed;

    [SerializeField] private GameObject[] bullets;

    // Update is called once per frame
    void Update()
    {
        gunTransform.Rotate(0, 0, - rotationSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
    }
}
