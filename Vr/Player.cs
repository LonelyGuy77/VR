using UnityEngine;
using System.Collections;

//동시적용
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : PlayerLife
{
    public static bool visible;
    public CharacterController Cc;
    public float moveSpeed = 5;
    Vector3 v3;
    Camera viewCamera;
    PlayerController controller;
    GunController gunController;
    private AudioSource Foot;
    float horizontalMove;
    float verticalMove;



    protected override void Start()
    {
        
        
        base.Start();
        controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
        Cursor.visible = false;//커서 삭제
        Foot = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetButton("Y Button"))
        {
            Cc.Move(transform.forward * moveSpeed * Time.deltaTime);
            Foot.Play();
        }
        if (Input.GetButton("A Button"))
        {
            Cc.Move(transform.forward *-1* moveSpeed * Time.deltaTime);
            Foot.Play();
        }
        if (Input.GetButton("X Button"))
        {
            Cc.Move(transform.right * -1 * moveSpeed * Time.deltaTime);
            Foot.Play();
        }
        if (Input.GetButton("B Button"))
        {
            Cc.Move(transform.right * 1 * moveSpeed * Time.deltaTime);
            Foot.Play();
        }

      

        if (Input.GetButtonDown("360_LeftBumper"))
        {
            gunController.Shoot();
          
        }
        if (Input.GetButtonDown("360_RightBumper"))
        {
            gunController.Shoot();

        }

    }
}