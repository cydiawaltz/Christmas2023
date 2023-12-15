using UnityEngine;

public class QuitUnity : MonoBehaviour
{
    void Update()
    {
        // Qキーが押されたらアプリケーションを終了
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Quit();
        }
    }

    void Quit()
    {
        // アプリケーションを終了
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
