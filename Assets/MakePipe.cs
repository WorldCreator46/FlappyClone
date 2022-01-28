using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff = 1f;
    public float min = 2.0f, max = 4.0f;
    float destroyTime = 7.0f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(min, max), 0);
            timer = 0;
            Destroy(newpipe, destroyTime);
        }
    }
}
