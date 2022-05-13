using System.Collections.Generic;
using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementspeed;
        public float rotationspeed;

        public TankTypes tanktypes;

        public Material color;
    }

    public List<Tank> tanklist;
    public TankView tankview;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateTank(TankTypes tanktypes)
    {
        if (tanktypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tanklist[1].movementspeed, tanklist[1].rotationspeed, tanklist[1].tanktypes, tanklist[1].color);
            TankController tankController = new TankController(tankModel, tankview);
        }

        else if (tanktypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tanklist[0].movementspeed, tanklist[0].rotationspeed, tanklist[0].tanktypes, tanklist[0].color);
            TankController tankController = new TankController(tankModel, tankview);
        }
        else if (tanktypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tanklist[2].movementspeed, tanklist[2].rotationspeed, tanklist[2].tanktypes, tanklist[2].color);
            TankController tankController = new TankController(tankModel, tankview);
        }
    }
}
