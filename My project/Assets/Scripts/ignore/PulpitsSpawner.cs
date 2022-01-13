    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitsSpawner : MonoBehaviour
{
    public Vector3 pulpit_position;
    public GameObject pulpit;


    // public bool stopSpawning = false;
    // public float spawnTime=2f;
    // public float spawnDelay=3f;
   
    // public float min_pulpit_destroy_time=4f;
    // public float max_pulpit_destroy_time=5f;
    // public float pulpit_spawn_time=2.5f;


    void Start()
    {
        StartCoroutine(generatePulpits());
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(pulpit,transform.position,transform.rotation);
    }
    public IEnumerator generatePulpits()
    {
        yield return new WaitForSeconds(0.2f);
        pulpit_position=new Vector3(Random.Range(5,20),0,Random.Range(5,20));
        Instantiate(pulpit,pulpit_position,transform.rotation);
        //Invoke("destroyPulpits",2);
    }

    public IEnumerator destroyPulpits()
    {
        yield return new WaitForSeconds(3f);
        Destroy(pulpit);
    }

}
