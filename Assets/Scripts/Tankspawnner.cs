using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    public TankView tankview;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(30,20);
        TankController tankController = new TankController(tankModel, tankview);
    }
}
