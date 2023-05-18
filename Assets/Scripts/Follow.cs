
using UnityEngine;

public class Follow : MonoBehaviour
{
    
    public Transform Player;
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, Player.position.y + 3.11f, transform.position.z);
        
     
    }       
        
}
