using UnityEngine;

public class LightControll : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;

    void Update()
    {
        // 左矢印が押されたら
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            EnableLight(light1);  // ライト1を有効にする
            DisableLight(light2); // ライト2を無効にする
        }

        // 右矢印が押されたら
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DisableLight(light1); // ライト1を無効にする
            EnableLight(light2);  // ライト2を有効にする
        }
    }

    void EnableLight(GameObject lightObject)
    {
        if (lightObject != null)
        {
            lightObject.SetActive(true);
        }
    }

    void DisableLight(GameObject lightObject)
    {
        if (lightObject != null)
        {
            lightObject.SetActive(false);
        }
    }
}
