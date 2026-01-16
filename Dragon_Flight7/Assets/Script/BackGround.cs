using UnityEngine;

public class BackGround : MonoBehaviour
{   
    public float scrollSpeed = 1f;
    private Material myMaterial;
    
    void Start()
    {
      //머터리얼 가져오기
      myMaterial = this.GetComponent<Renderer>().material;   
    }


    void Update()
    {   
        //오프셋 머터리얼에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;
        //새롭게 offset 바꿔주기

        newOffset.Set(0,newOffset.y + (scrollSpeed * Time.deltaTime));

        myMaterial.mainTextureOffset = newOffset;
    }
}
