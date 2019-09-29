using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MinigameBehaviour
{
    Vector3 pos = new Vector3(0.15f, 0.15f);
    float wait;
    // Start is called before the first frame update
    protected override void Start()
    {

    }

    protected override void OnStateEnter()
    {
        
    }

    protected override void OnStateExit()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (wait >= 3.5)
        {
            if (transform.position.x <= 15 & transform.position.y <= 15)
            {
                transform.position += pos;
            }
        }
        wait += Time.deltaTime;
    }
}
