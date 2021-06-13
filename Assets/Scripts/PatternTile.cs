using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternTile : MonoBehaviour
{
	public GameObject[] tiles;
	public int maxTime = 5;
	private float time;
	private bool on = true;
	private int selector = 2;
	private bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
	
        time = maxTime;
	on = true;
    }

    // Update is called once per frame
    void Update()
    {
	if (!paused)
	{
		StartCoroutine(AppearDisappear());
	}

	IEnumerator AppearDisappear()
	{
		paused = true;
		

		on = !on
		if (on)
		{
			for (int i = 0; i < tiles.Length; i++)
			{
				if (i+1 % selector == 0)
				{
					tiles[i].SetActive(true);
				}
			}
		}
		else
		{
			for (int i = 0; i < tiles.Length; i++)
			{
				if (i+1 % selector == 0)
				{
					tiles[i].SetActive(false);
				}
			}

		}

		selector++;
		if (selector >= tiles.Length)
		{
			selector = 2;
		}
		yield return new WaitForSeconds(maxTime);
		
		paused = false;
	}
    {/*
        time -= Time.deltaTime;

	if (time < 0)
	{
		on = !on;
        		time = maxTime;
		
		for (int i = 0; i < tiles.Length; i++)
		{
			if (i+1%selector == 0)
			{
				
				if (on)
            			{
                				tiles[i].SetActive(true);
            			}
            			else
            			{
                				tiles[i].SetActive(false);
            			}	
			}
		}
		

				if (on)
            			{
                				
					for (int i = 0; i < tiles.Length; i++)
					{
						if (i+1%selector == 0)
						{
							tiles[i].SetActive(true);	
						}
					}
            			}
            			else
            			{
                				for (int i = 0; i < tiles.Length; i++)
					{
						if (i+1%selector == 0)
						{
							tiles[i].SetActive(false);	
						}
					}
            			}	

		selector++;
		if (selector >= tiles.Length)
		{
			selector = 2;
		}*/
	}
    }
}
