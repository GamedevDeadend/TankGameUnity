using UnityEngine;

public class TankModel
{
    private TankController tankController;

    
    public float movementspeed;
    public float rotationspeed;

    public TankModel(float _movementspeed, float _rotationspeed)
    {
        movementspeed = _movementspeed;
        rotationspeed = _rotationspeed;
    }
    // Start is called before the first frame update

    public void SetController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
