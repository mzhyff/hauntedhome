using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class blockcon : MonoBehaviour
{
    public Transform nextBlock;
    public Transform thisBlock;

    // Start is called before the first frame update
    //public GameObject textbox;
    //trying figure out how to call the script array
    //public GameObject worldbuild;

    //question: does on mouse up needs to be when mouse is on ui
    // was looking at this:' https://www.reddit.com/r/unity/comments/og37ws/how_can_i_detect_mouse_clicks_on_canvas/ '

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.tag != "lastBlock") { 
        Instantiate(nextBlock, transform.position, thisBlock.rotation);
            //textbox.GetComponent<Text>().text = script.getText();

        }
        Destroy(gameObject);
    }


}
