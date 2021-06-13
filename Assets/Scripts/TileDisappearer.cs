using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDisappearer : MonoBehaviour
{
    public int maxTime = 10;

    private float time;
    private int seconds;
    private bool on;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        seconds = random.Next(1, maxTime + 1);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            on = !on;
            time = seconds;

            if (on)
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
