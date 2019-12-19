using UnityEngine;
using UnityEngine.UI;           // 引用 介面 API

public class Player : MonoBehaviour
{
    [Header("血量與血條")]
    public int hp = 100;        // 血量
    public Slider hpSlider;     // 血量滑桿
    [Header("雞腿區域")]
    public Text textChicken;    // 雞腿文字介面
    public int chickenCount;    // 雞腿數量
    public int chickenTotal;    // 雞腿總數

    // 觸發事件：碰到勾選 IsTrigger 物件會執行一次
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "陷阱")                        // 如果 碰到.標籤 等於 "陷阱"
        {
            int d = other.GetComponent<Trap>().damage;  // 取得元件<泛型>().成員
            hp -= d;                                    // 血量 扣 傷害值
            hpSlider.value = hp;                        // 血量滑桿.值 = 血量
        }

        if (other.tag == "雞腿")
        {
            chickenCount++;
            textChicken.text = "CHICKEN : " + chickenCount + " / " + chickenTotal;
            Destroy(other.gameObject);
        }

        // 如果 碰到.名稱 為 "終點" 並且 雞腿數量 =等於 雞腿總數
        if (other.name == "終點" && chickenCount == chickenTotal) 
        {
            print("過關");
        }
    }

    // 粒子碰撞事件：碰到勾選 Send Collision Messages 粒子會執行一次
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "陷阱")                        // 如果 碰到.標籤 等於 "陷阱"
        {
            int d = other.GetComponent<Trap>().damage;  // 取得元件<泛型>().成員
            hp -= d;                                    // 血量 扣 傷害值
            hpSlider.value = hp;                        // 血量滑桿.值 = 血量
        }
    }

    private void Start()
    {
        chickenTotal = GameObject.FindGameObjectsWithTag("雞腿").Length;    // 雞腿總數 = 遊戲物件.透過標籤尋找複數物件("標籤名稱").數量
        textChicken.text = "CHICKEN : 0 / " + chickenTotal;                 // 雞腿文字介面.文字 = "CHICKEN : 0 / " + 雞腿總數
    }
}
