using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private float movement;
    private float rotation;

    private TankController tankController;

    public Rigidbody rb;

    public MeshRenderer[] child;

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 5f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movement!=0)
        tankController.Move(movement,tankController.GetTankModel().movementspeed);

        if (rotation!=0)
        tankController.Rotate(rotation, tankController.GetTankModel().rotationspeed);
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

    public void ChangeColor(Material color)
    {
        for (int i = 0; i<child.Length; i++)
        {
            child[i].material = color;
        }
    }
}
