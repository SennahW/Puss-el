using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToButton : MonoBehaviour
{

    public GameObject platForm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exit");
        if (collision.gameObject.tag == "PlayerOne" && collision.gameObject.name == "Body" || collision.gameObject.tag == "PlayerTwo" && collision.gameObject.name == "Body")
        {
            platForm.GetComponent<Buttons>().yesItDoesWork = false;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Collision Enter");
        if (collision.gameObject.tag == "PlayerOne" && collision.gameObject.name == "Body" || collision.gameObject.tag == "PlayerTwo" && collision.gameObject.name == "Body")
        {
            platForm.GetComponent<Buttons>().yesItDoesWork = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerOne" && collision.gameObject.name == "Body" || collision.gameObject.tag == "PlayerTwo" && collision.gameObject.name == "Body")
        {
            platForm.GetComponent<Buttons>().yesItDoesWork = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerOne" && collision.gameObject.name == "Body" || collision.gameObject.tag == "PlayerTwo" && collision.gameObject.name == "Body")
        {
            platForm.GetComponent<Buttons>().yesItDoesWork = false;
        }
    }




}



