using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    // Update is called once per frame

        }

        
        // ÒÆ¶¯ÎïÌå
        transform.position = Vector2.MoveTowards(transform.position, targetPoint.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerEnter = false;
        }
    }
}

