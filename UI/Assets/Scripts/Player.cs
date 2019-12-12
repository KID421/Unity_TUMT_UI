using UnityEngine;

public class Player : MonoBehaviour
{
    // 觸發事件：碰到勾選 IsTrigger 物件會執行一次
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
    }
}
