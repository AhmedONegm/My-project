using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    public void onButtonClicked(){
        Instantiate(objectToSpawn, new Vector3(0,0,0), Quaternion.identity);
    }
}
