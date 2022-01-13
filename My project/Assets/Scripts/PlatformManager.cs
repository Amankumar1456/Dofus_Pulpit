using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    int child;
    void Start()
    {
        InvokeRepeating("SpawnPlatform",1f,0.1f);    
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    void Update() {
        child=(int)Random.Range(0f,5f);
        platform=this.gameObject.transform.GetChild(child).gameObject;
    }
    void SpawnPlatform()
    {
        platform.SetActive(true);
        StartCoroutine(destroy()); 
    }
    
    public IEnumerator destroy()
    {
        yield return new WaitForSeconds(5f);
        platform.SetActive(false);
    }
    
}
