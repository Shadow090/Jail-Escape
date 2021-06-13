using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
	public GameObject IntroPanel;
	public float timeleft;
	private bool flag;
    // Start is called before the first frame update
    void Start()
    {
	timeleft = 180;
	flag = true;
    }

    // Update is called once per frame
    void Update()
    {
	if (timeleft >= 0)
	{
		timeleft -= Time.deltaTime;	
	}
	
	if (timeleft < 0 && flag)
	{
		IntroPanel.SetActive(false);
		flag = false;
	}
    }
}
