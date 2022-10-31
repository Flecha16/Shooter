using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public AudioSource a;
    public AudioClip s;

    public float shotForce = 1500;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    public float volumen = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            a.PlayOneShot(s,volumen);
            
            if (Time.time > shotRateTime){
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet, 2);
            }
        }
    }
}
