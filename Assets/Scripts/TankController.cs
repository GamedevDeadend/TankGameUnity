using UnityEngine;

public class TankController

{
    // public TankController tankcontroller;
    public TankModel tankModel;
    public TankView tankview;

    private Rigidbody rb;

    public TankController(TankModel _tankmodel, TankView _tankview)
    {
        tankModel = _tankmodel;
        tankview = GameObject.Instantiate<TankView>(_tankview);  //Not Understood
        rb = tankview.GetRigidbody();
        tankModel.SetController(this);
        tankview.SetController(this);
        tankview.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float movementspeed)
    {
        rb.velocity = tankview.transform.forward*movement*movementspeed; 
    }
    public void Rotate(float rotate, float rotationspeed)
    {
        Vector3 vector = new Vector3(0f,rotate*rotationspeed,0f);
        Quaternion deltarotation = Quaternion.Euler(vector*Time.deltaTime);
        rb.MoveRotation(rb.rotation*deltarotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}

