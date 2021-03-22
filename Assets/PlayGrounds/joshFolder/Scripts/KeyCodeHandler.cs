using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeHandler : MonoBehaviour
{
    private bool message = false;
    private float xPos = Screen.width*0.5f-51f;
    private float yPos = Screen.height*0.25f-51f;

    private int keyCode = 1250;
    private int currInput = 0;

    private int totalInput = 0;

    public Transform openDoor;

    public bool keyCodeScreen = false;

    public GameObject keyCodeEntryCamera;

    public GameObject mainCamera;

    public GameObject playerMove;

    public GameObject weaponHolder;

    public GameObject keyPadPanel;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Enter");
            message = true;
            Debug.Log(message + " line 36");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Player")
        {
            message = false;
        }
    }

    private void OnGUI()
    {
        if(message == true)
        {
            Debug.Log("where is the GUI?");
            GUI.Box(new Rect(xPos, yPos, 132, 22), "Press E to interact");
        }
        if(message && Input.GetKeyDown(KeyCode.E))
        {
            keyCodeScreen = true;
            message = false;
            // Debug.Log("KeyCodeScreen " + keyCodeScreen);
        }
        useKeyPad();
    }

    private void useKeyPad()
    {
        if(keyCodeScreen == true)
        {
            Debug.Log("KeyCodeScreen " + keyCodeScreen);
            // playerBody.SetActive(false);
            // GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
            // keyCodeEntryCamera.SetActive(true);
            mainCamera.GetComponent<MouseLook>().enabled = false;
            playerMove.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            weaponHolder.SetActive(false);
            keyPadPanel.SetActive(true);
            // HUD.SetActive(false);


            // RaycastHit hit;
            // Ray raycast = Camera.main.ScreenPointRelay(Input.mousePosition);

            // if(Physics.Raycast(raycast, out hit, 100.0f))
            // {
            //     var selection = hit.transform;
            //     if(selection)
            // }
        // }
        // if(keyCodeScreen)
        // {
            // GUI.Box(new Rect(0, 0, 400, 400), "");
            // GUI.Box(new Rect(5, 5, 310, 25), currInput.ToString());
            // if( GUI.Button(new Rect(5, 35, 100, 100), "2"))
            // {
            //     if(Input.GetButtonDown("Fire1"))
            //     {
            //         currInput = 2;
            //         totalInput *= currInput;
            //         Debug.Log("curr: " + currInput + " total: " + totalInput);

            //     }
            // }
            // if( GUI.Button(new Rect(110, 35, 100, 100), "3"))
            // {
            //     currInput = 3;
            //     totalInput *= currInput;
            // }
            // if( GUI.Button(new Rect(215, 35, 100, 100), "5"))
            // {
            //     currInput = 5;
            //     totalInput *= currInput;
            // }
            // if( GUI.Button(new Rect(5, 140, 100, 100), "7"))
            // {
            //     currInput = 7;
            //     totalInput *= currInput;
            // }
            // if( GUI.Button(new Rect(110, 140, 100, 100), "9"))
            // {
            //     currInput = 9;
            //     totalInput *= currInput;
            // }
            // if( GUI.Button(new Rect(215, 140, 100, 100), "C"))
            // {
            //     currInput = 0;
            //     totalInput = currInput;
            // }
        }
    }


    
    // Update is called once per frame
    void Update()
    {
        if(message && Input.GetKeyDown(KeyCode.E))
        {
        //     useKeyPad();
            // if(totalInput == keyCode)
            // {
                openDoor.GetComponent<Animation>().CrossFade("Open");
            }
            // doorLogic.setLockStatus(false);
        }
    }
}
