using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeManager : MonoBehaviour
{
    private Vector3 start_pos, shake_pos;
    public float speed, amount, duration;

    void Start()
    {
        shake_pos = transform.position;
        speed = amount = duration = 0;
    }

    void Update()
    {
        if(duration > 0)
        {
            Shake();
            duration -= Time.deltaTime;
        }else
        {
            transform.position = Vector3.MoveTowards(transform.position, start_pos, Time.deltaTime * Mathf.Abs(speed));
        }    
    }

    void Shake()
    {
        if (transform.position == shake_pos)
        {
            shake_pos = start_pos + new Vector3(Random.Range(-amount, amount), Random.Range(-amount, amount), 0);

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, shake_pos, Time.deltaTime * Mathf.Abs(speed));
        }
}
}
