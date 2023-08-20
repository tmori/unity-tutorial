using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Text value;
    // Start is called before the first frame update
    void Start()
    {

    }
    int parameter = 0;
    // Update is called once per frame
    void Update()
    {
        Renderer renderer = this.GetComponent<Renderer>();

        if (renderer != null)
        {
            Material material = renderer.material;

            float normalizedParameter = Mathf.Clamp01(parameter / 1000f);

            Color startColor = Color.white;
            Color endColor = Color.red;
            Color newColor = Color.Lerp(startColor, endColor, normalizedParameter);

            material.color = newColor;

            string filePath = "./test.csv";
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string line = null;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                }
                reader.Close();
                this.parameter = int.Parse(line);
                if (parameter < 0)
                {
                    parameter = 0;
                }
                else if (parameter > 1000)
                {
                    parameter = 1000;
                }
                this.value.text = parameter.ToString();
            }
            catch (Exception e)
            {
                parameter = 0;
            }
        }
    }
}
