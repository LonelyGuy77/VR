using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameStrat : MonoBehaviour {

	
	void Start () {
	
	}


    //버튼클릭

    public void Button()
    {
       
            Invoke("gameStrat", 3f);
   
            
    }
    

   private void gameStrat()
    {
    
      SceneManager.LoadScene("TEST2");

    }

    //패드사용

    void Update () {
        if (Input.GetButton("360_Strat"))
        {
            SceneManager.LoadScene("TEST2");
        }

        if (Input.GetButton("360_RightBumper"))
        {
            SceneManager.LoadScene("TEST2");
        }

        if (Input.GetButton("360_LeftBumper"))
        {
            SceneManager.LoadScene("TEST2");
        }

    }
}
