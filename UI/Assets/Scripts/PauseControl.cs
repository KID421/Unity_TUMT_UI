using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    [Header("暫停介面")]
    public Image imagePause;
    public Sprite spritePause, spritePlay;
    [Header("暫停")]
    public bool pause;

    /// <summary>
    /// 暫停方法
    /// </summary>
    private void Pause()
    {
        // 如果 按下 ESC 就執行 {}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("暫停~");
            pause = !pause;     // ! 相反：將布林值改為相反
        }
    }

    // 更新：一秒執行約 60 次
    private void Update()
    {
        Pause();
    }
}
