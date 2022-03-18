using UnityEngine;
public class PlayerDeath : MonoBehaviour
{
    
    public GameObject compareObject;
    void Update () {
        if(Vector3.Distance(compareObject.transform.position, transform.position) < 1){
            FindObjectOfType<gameManager>().lose();
        }
    }
}
