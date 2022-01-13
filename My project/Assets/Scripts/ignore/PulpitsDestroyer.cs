using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitsDestroyer : MonoBehaviour
{
    void Destruction() {
		Destroy(this.gameObject);
	}
    void Start()
    {
        Invoke("Destruction",5f);
    }
}
