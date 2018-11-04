using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterToContinue : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {

		if(Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
	}
}
