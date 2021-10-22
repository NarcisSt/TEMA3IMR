using UnityEngine;

public class MessageWhenScore : MonoBehaviour
{
    public GameObject message;
    
    // Start is called before the first frame update
     void Start()
    {
        message.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.name ==("BasketNet"))
        {
            message.SetActive(true);
        }
    }
    
}
