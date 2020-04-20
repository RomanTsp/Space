using UnityEngine;
using System.Collections;

public class moveBull : MonoBehaviour
{

    public float maxSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * maxSpeed * Time.deltaTime;
    }
}
