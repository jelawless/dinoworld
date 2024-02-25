using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnV : MonoBehaviour
{
    public GameObject myVDino;

    public void Spawn()
    {
        Instantiate(myVDino);
    }

    

}
