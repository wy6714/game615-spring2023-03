using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    public int score;
    float moveSpeed = 5f;
    float rotateSpeed = 75f;

    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        TimerOn = true;
        TimeLeft = 30;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);

        /*
        if(score == 6)
        {
            ScoreText.text = "You Win!";
        }
        */

        if (TimerOn)
        {
            if(TimeLeft > 0 && score < 6)
            {
                TimeLeft -= Time.deltaTime;
                TimerText.text = TimeLeft.ToString();
            }else if(TimeLeft > 0 && score==6){
                ScoreText.text = "You Win!";
            }else
            {
                TimeLeft = 0;
                TimerText.text = TimeLeft.ToString();
                TimerOn = false;
                ScoreText.text = "You lose! Don't know how to stop game yet, so just pretend gameover:D";

            }
        }

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
