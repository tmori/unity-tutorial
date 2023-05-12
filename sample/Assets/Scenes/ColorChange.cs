using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    int parameter = 0;
    int way = 1;
    // Update is called once per frame
    void Update()
    {
        Renderer renderer = this.GetComponent<Renderer>();

        if (renderer != null)
        {
            // マテリアルを取得
            Material material = renderer.material;

            // パラメータの値を0から1の範囲に正規化
            float normalizedParameter = Mathf.Clamp01(parameter / 1000f);

            // 色の変化を計算
            Color startColor = Color.white; // パラメータが0の場合の色（白）
            Color endColor = Color.red; // パラメータが100の場合の色（赤）
            Color newColor = Color.Lerp(startColor, endColor, normalizedParameter);

            // マテリアルの色を変更
            material.color = newColor;

            this.parameter += this.way;
            if (this.parameter >= 500)
            {
                this.way = -1;
            }
            else if (this.parameter <= 0)
            {
                this.way = 1;
            }
        }
    }
}
