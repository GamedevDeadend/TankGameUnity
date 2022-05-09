using UnityEngine;

public class Tankspawnner : MonoBehaviour
{
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Tank, transform.position, Quaternion.identity);
    }
}
