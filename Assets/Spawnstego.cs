using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnstego : MonoBehaviour
{
    public GameObject mySDino;

    public void Spawn()
    {
        Instantiate(mySDino);
    }

}