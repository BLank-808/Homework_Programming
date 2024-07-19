using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
using System;
public class PlayerMovement : MonoBehaviour
{
    public Vector2 Mpos;
    public Rigidbody2D player;
    public Camera cam;
    private float xpos;
    private float ypos;
    void Update()
    {

        Mpos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Dir = Mpos - player.position;
        float angle = (Mathf.Atan2(Dir.y, Dir.x) * Mathf.Rad2Deg) - 90f;
        player.rotation = angle;
        ypos = Input.GetAxis("Vertical");
        xpos = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(xpos * 2, ypos * 2);
    }
}
