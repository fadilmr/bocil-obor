using UnityEngine;
public class PlayerDeath : MonoBehaviour
{
    
    public GameObject compareObject;
    void Update () {
        if(Vector3.Distance(compareObject.transform.position, transform.position) < 0.5){
            FindObjectOfType<gameManager>().lose();
        }
    }
}
