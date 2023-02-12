using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    // Start is called before the first frame update
    public birdscript birdDeth;
    public LogicScript logic;
    public birdscript bird;
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent<birdscript>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        logic.gameOver();
        bird.birdIsAlive = false;
    }
}
