using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{

    public int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("babyBottle"))
        {
            Destroy(other.gameObject);
            addScore();
        }

        void addScore()
        {
            score++;
        }
    }
}
