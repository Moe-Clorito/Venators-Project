using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgbd2d;

    Vector3 mvmntVector;

    [SerializeField] float speed = 3f;

    Animation animate;

    private void Awake()
    {
        rgbd2d= GetComponent<Rigidbody2D>();
        mvmntVector = new Vector3();
        animate = GetComponent<Animation>();
    }


    // Update is called once per frame
    void Update()
    {
        mvmntVector.x = Input.GetAxisRaw("Horizontal");
        mvmntVector.y = Input.GetAxisRaw("Vertical");
        mvmntVector *= speed;

        animate.horizontal = mvmntVector.x;

        rgbd2d.velocity = mvmntVector;
    }
}
