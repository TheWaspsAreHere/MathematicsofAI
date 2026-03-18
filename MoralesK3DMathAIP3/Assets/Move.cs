using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    float speed = 0.005f;

    void Start() 
    {
        direction = goal.transform.position - transform.position;
        this.transform.position = this.transform.position + direction;
    }

    private void LateUpdate() 
    {
        Vector3 velocity = direction.normalized * speed;
        this.transform.position = this.transform.position;
    }
}
