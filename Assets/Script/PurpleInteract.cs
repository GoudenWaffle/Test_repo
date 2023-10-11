using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleInteract : MonoBehaviour
{

    public GameObject dialogBox2;
    private float interactionRange = 5f;
    public GameObject InteractWith2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, InteractWith2.transform.position) < interactionRange)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("hit");
                dialogBox2.SetActive(true); //show the dialogue
            }
        }
        else
        {
            dialogBox2.SetActive(false); // hide
        }



    }
}
