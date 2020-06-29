using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawener : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }
    void Spawn()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        position.y = Random.Range(1f, 1f); //arriba - abajo
        position.x = Random.Range(-1f, 1f); //izq - derecha
        Instantiate(prefab, position, Quaternion.identity);
    }
}

