using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject rock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        Instantiate(rock);
        yield return new WaitForSeconds(3);
    }
}
