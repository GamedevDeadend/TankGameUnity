using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawnner tankSpawnner;
    public void BlueTankSelected()
    {
        // Debug.Log("Working");
        tankSpawnner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }
    public void GreenTankSelected()
    {
        tankSpawnner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);

    }
    public void RedTankSelected()
    {
        tankSpawnner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
