using UnityEngine;
using System.Diagnostics;

public class one : MonoBehaviour
{
    public GameObject objectToCheck; // 確認するオブジェクト
    public KeyCode launchKey = KeyCode.X; // 起動キー
    public string appPath = "app1/saitama.exe"; // アプリケーションのパス

    void Update()
    {
        // オブジェクトが有効かつキーが押されたら
        if (objectToCheck != null && objectToCheck.activeSelf && Input.GetKeyDown(launchKey))
        {
            // アプリケーションを起動
            LaunchApplication(appPath);
        }
    }

    void LaunchApplication(string path)
    {
        try
        {
            Process.Start(path);
        }
        catch (System.Exception e)
        {
            UnityEngine.Debug.LogError("アプリケーションの起動中にエラーが発生しました: " + e.Message);
        }
    }
}
