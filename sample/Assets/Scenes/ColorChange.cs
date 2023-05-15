using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
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
            StreamReader reader = new StreamReader(filePath);

            string line = null;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
            }
            reader.Close();

            this.parameter = int.Parse(line);
        }
    }
}
