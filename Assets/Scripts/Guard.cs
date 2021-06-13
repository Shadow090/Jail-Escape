using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
    public GameObject player;
    public GameObject losePanel;
    public bool alerted;
    public float speed = 10f;

    private NavMeshAgent navMesh;
    private Vector3 home;

    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.speed = speed;

        home = transform.position;
        alerted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (alerted)
        {
            navMesh.destination = player.transform.position;
        }

        else
        {
            navMesh.destination = home;
        }
    }
        private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player") && alerted)
        {
                losePanel.SetActive(true);
                Time.timeScale = 0f;
        }
         
    }
}

