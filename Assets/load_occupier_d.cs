using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_occupier_d : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;  
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("t_o_d", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("a_renter", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("b_landlords", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("c_complicated", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("a_renter", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("b_landlords", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("home", LoadSceneMode.Single);
        }
    }
}

