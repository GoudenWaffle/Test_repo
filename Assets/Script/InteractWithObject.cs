using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractWithObject : MonoBehaviour
{
    public GameObject InteractWith;
    public GameObject InteractWith2;
    public float interactionRange = 5f;//effective range for dialogue to pop up
    public GameObject dialogBox;
    public GameObject dialogBox2;
    public bool haveKey = false;



    void OnCollisionEnter2D(Collision2D collision)//must have a rigid/box collider, and IS TRIGGER must be checked
                                                  //below all are collide trigger reactions
    {
        if (collision.gameObject.name == "Key")
        {
            Destroy(collision.gameObject);
            haveKey = true;
        }

        if (collision.gameObject.name == "Door" && haveKey)
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "TreeKing" && haveKey)
        {
            SceneManager.LoadScene("Start");
        }

    }


    


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, InteractWith.transform.position) < interactionRange)


        {
            Debug.Log("hit");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogBox.SetActive(true); //show the dialogue
            }
        }else
            {
            dialogBox.SetActive(false); // hide
            }


        if (Vector3.Distance(transform.position, InteractWith2.transform.position) < interactionRange)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogBox2.SetActive(true); //show the dialogue
            }
        }
        else
        {
            dialogBox2.SetActive(false); // hide
        }








    }
}
