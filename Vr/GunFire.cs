using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour {
    public GameObject Fire;

  
    void Start () {
        Fire.SetActive(false);
    }
	
	
	void Update () {
        if (Input.GetButtonDown("360_LeftBumper")||Input.GetButtonDown("360_RightBumper"))
        {
            Fire.SetActive(true);
        }
        else
        {
            Fire.SetActive(false);
        }


       

    }
}
