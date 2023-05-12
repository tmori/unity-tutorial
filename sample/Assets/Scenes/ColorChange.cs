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
            // �}�e���A�����擾
            Material material = renderer.material;

            // �p�����[�^�̒l��0����1�͈̔͂ɐ��K��
            float normalizedParameter = Mathf.Clamp01(parameter / 1000f);

            // �F�̕ω����v�Z
            Color startColor = Color.white; // �p�����[�^��0�̏ꍇ�̐F�i���j
            Color endColor = Color.red; // �p�����[�^��100�̏ꍇ�̐F�i�ԁj
            Color newColor = Color.Lerp(startColor, endColor, normalizedParameter);

            // �}�e���A���̐F��ύX
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
