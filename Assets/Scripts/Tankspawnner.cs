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
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tanklist[2].movementspeed, tanklist[2].rotationspeed, tanklist[2].tanktypes, tanklist[2].color);
        TankController tankController = new TankController(tankModel, tankview);
    }
}
