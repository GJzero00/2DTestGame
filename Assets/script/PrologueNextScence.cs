using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class PrologueNextScence : MonoBehaviour
{
    public Animator anim;
   void NextScence()
    {
        
        SceneManager.LoadScene(2);

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("NextScence", 12f);
    }
}
