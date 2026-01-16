using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //x쪽 설정 
        float distanceX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        //y쪽 설정
        transform.Translate(distanceX,0,0);
    }
}
