using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovementscript : MonoBehaviour
{
    public float movespeed;
    public float deadZone = -40;
    public LogicScript logic;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("pipe destroyed");
            Destroy(gameObject);
        }
    }
}
