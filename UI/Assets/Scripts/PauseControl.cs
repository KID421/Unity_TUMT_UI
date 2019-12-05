using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    [Header("暫停介面")]
    public Image imagePause;
    public Sprite spritePause, spritePlay;

    /// <summary>
    /// 暫停方法
    /// </summary>
    private void Pause()
    {
        print("暫停~");
    }

    // 更新：一秒執行約 60 次
    private void Update()
    {
        Pause();
    }
}
