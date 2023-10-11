using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI dialogText;// given a thing (about text), and we name it dialogText
    public bool isTextA = true;
    public InteractWithObject InteractWithObject;


    // Start is called before the first frame update
    void Start()
    {
        UpdateDialog();//custom method//that from this beginning we have keytrue and ready to active dialogue A
    }

    // Update is called once per frame
    void Update()
    {
        if (InteractWithObject.haveKey) // should receive 2nd dialogue from Orange 
        {
            isTextA = false;//is B, it's 2nd!
            UpdateDialog();
        }
    }


    void UpdateDialog()//oho right here
    {
        if (isTextA)
        {
            dialogText.text = "Key to open the gate is EAST of here.";
        }
        else
        {
            dialogText.text = "My friend behind the gate might help you!";
            
        }
    }






}
