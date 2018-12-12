using UnityEngine;
using System.Collections;

public class Generator : MonoBehavior
{
    public GameObject prefab;
    public static GameObject Earth;
    public static float lastTime;

    void Update()
    {
        Earth = GameObject.FindGameObjectWithTag("Earth");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastTime = Time.time;
            Instantiate(prefab, Earth.transform.position, Quaternion.identity);
        }
    }
}