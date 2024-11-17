using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgrateController : MonoBehaviour
{
    public MeshRenderer mr;
    public Color color;
    public Shader shader;

    public Texture textureBlue;
    public Texture textureYellow;
    public Texture textureRed;
    public Texture textureBlack;
    public Texture textureGreen;
    private void Start() {
        if (PlayerPrefs.GetInt("PlayerColor") == 0)
        {
            ChangeTexture(textureBlue);
        }
        if (PlayerPrefs.GetInt("PlayerColor") == 1)
        {
            ChangeTexture(textureYellow);
        }
        if (PlayerPrefs.GetInt("PlayerColor") == 2)
        {
            ChangeTexture(textureRed);
        }
        if (PlayerPrefs.GetInt("PlayerColor") == 3)
        {
            ChangeTexture(textureBlack);
        }
        if (PlayerPrefs.GetInt("PlayerColor") == 4)
        {
            ChangeTexture(textureGreen);
        }
    }

    public void ChangeTexture (Texture t) {
        Renderer mr = GetComponent<MeshRenderer>();
        mr.material = new Material(shader);
        mr.material.mainTexture = t;
        mr.material.color = color;
    }
}
