using UnityEngine;

//[RequireComponent(typeof(BoxCollider))]
public class Trap : MonoBehaviour
{
    //private void Reset()
    //{
    //GetComponent<BoxCollider>().isTrigger = true;
    //}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("MinusLife", 1);
            //FindObjectOfType<LifeCount>().LoseLife();
        }
    }
    private void MinusLife()
    {
        FindObjectOfType<LifeCount>().LoseLife();
    }

}