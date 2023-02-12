using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMidlescript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.layer == 3)
            logic.addScore(1);
    }
}
