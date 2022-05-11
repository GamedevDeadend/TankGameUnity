using UnityEngine;

public class TankModel
{
    private TankController tankController;


    public float movementspeed;
    public float rotationspeed;

    public TankTypes tanktype;

    public Material color;

    public TankModel(float _movementspeed, float _rotationspeed, TankTypes _tanktype, Material _color)
    {
        movementspeed = _movementspeed;
        rotationspeed = _rotationspeed;
        tanktype = _tanktype;
        color = _color;
    }
    // Start is called before the first frame update

    public void SetController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
