using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private float movement;
    private float rotation;

    private TankController tankController;

    public Rigidbody rb;

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movement!=0)
        tankController.Move(movement,30);

        if (rotation!=0)
        tankController.Rotate(rotation, 20);
    }

    public void SetController(TankController _tankController)
    {
        tankController = _tankController;
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
}
