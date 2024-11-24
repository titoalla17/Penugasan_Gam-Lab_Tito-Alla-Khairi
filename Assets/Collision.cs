using UnityEngine;

public class Collision : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("ENTER");
        }
    }

    void onTriggerStay(Collider other)
    {
         if (other.gameObject.tag == "enemy")
        {
            print("STAY");
        }
    }
    
    void onTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "enemy")
        {
            print("EXIT");
        }
    }
}
