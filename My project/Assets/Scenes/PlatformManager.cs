using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    
    public GameObject platform;
    int child;
    void Start()
    {
        InvokeRepeating("SpawnPlatform",3f,1f);    
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    void Update() {
        child=(int)Random.Range(0f,5f);
        platform=this.gameObject.transform.GetChild(child).gameObject;
    }
    void SpawnPlatform()
    {
        platform.SetActive(true);
        StartCoroutine(destroyPlatform()); 
    }
    
    public IEnumerator destroyPlatform()
    {
        yield return new WaitForSeconds(5f);
        platform.SetActive(false);
    }
    
}
