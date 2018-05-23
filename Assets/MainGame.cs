using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public Player Player;
    public GameObject MainCamera;
    public float PlayerSpeed = 10f;
    public float PlayerJumpForce = 3f;
    public float StageEdageStart = 0;
    public float StageEdageEnd = 40;
    private Rigidbody2D PlayerRigidbody2D;

    // Use this for initialization
    private void Start()
    {
        PlayerRigidbody2D = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerKeepMove();
        PlayerControl();
        CameraFollow();
    }

    private void CameraFollow()
    {
        float x = Player.transform.position.x;
        if (x > StageEdageStart && x < StageEdageEnd) MainCamera.transform.position = new Vector3(x, 0, -10);
    }

    private void PlayerControl()
    {
        if (Input.GetKeyDown("a")) { };
        if (Input.GetKeyDown("d")) { };
        if (Input.GetKeyDown("space"))
        {
            if (Player.IsOnFloor == false) return;
            PlayerRigidbody2D.AddForce(Vector2.up * PlayerJumpForce);
        }
        if (Input.GetKeyUp("space"))
        {
            PlayerRigidbody2D.velocity = new Vector2(PlayerRigidbody2D.velocity.x, PlayerRigidbody2D.velocity.y * 0.65f);
        }
    }



    private void PlayerKeepMove()
    {
        Player.transform.localPosition += Vector3.right * Time.deltaTime * PlayerSpeed;

    }
}
