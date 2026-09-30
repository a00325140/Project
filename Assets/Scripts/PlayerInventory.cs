using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public int NumberOfCollectibles { get; private set; }

    public void CollectibleCollected() 
    {
        NumberOfCollectibles++;
    }
    
}
