using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTRex : MonoBehaviour
{ 
    public GameObject myTRex;

    public void Spawn()
    {
        Instantiate(myTRex);
    }

}
