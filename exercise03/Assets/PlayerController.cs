using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    
    public TextMeshProUGUI ScoreText;
    public int score;
    float moveSpeed = 5f;
    float rotateSpeed = 75f;

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("babyBottle"))
        {
            Destroy(other.gameObject);
            ScoreText.text = score.ToString();
            score++;
        }

        
    }

    
}
