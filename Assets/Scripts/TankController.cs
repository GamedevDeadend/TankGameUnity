using UnityEngine;

public class TankController

{
    // public TankController tankcontroller;
    public TankModel tankModel;
    public TankView tankview;
    public TankController(TankModel _tankmodel, TankView _tankview)
    {
        tankModel = _tankmodel;
        tankview = _tankview;
        tankModel.SetController(this);
        tankview.SetController(this);

        GameObject.Instantiate(tankview.gameObject);
    }
}
