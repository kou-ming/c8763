using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public GameObject prefab;
    public Transform prefabPos;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, prefabPos);
        }
    }
}
