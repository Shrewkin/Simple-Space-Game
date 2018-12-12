using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour
{
    //Range For Speed
    [Range(0, 100)]
    public float speed = 20;
    public float alpha;
    public float distance;
    public float Rotation;
    public float currentTime;

    void Start()
    {
        Rotation = Random.Range(-2.0f, 2.0f);
        distance = Random.Range(1.0f, 2.0f);
        var Size = Random.Range(0.2f, 0.7f);
        transform.localScale = new Vector3(Size, Size, Size);

        currentTime = Time.time - Generator.lastTime;
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        var X = (distance * Mathf.Cos(currentTime));
        var Y = (distance * Mathf.Sin(currentTime));
        var R = (Rotation * Mathf.Cos(currentTime));

        var Earth = Generator.Earth;
        transform.position = Earth.transform.position + new Vector3(X, R, Y);
    }
}