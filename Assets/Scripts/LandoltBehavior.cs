using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandoltBehavior : MonoBehaviour {

    public InputField b1, b2, b3, r1, r2, r3;
    public Image background;
    public Text scaleText;
    private int scale = 1;

    private float b1f, b2f, b3f, r1f, r2f, r3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeColor() {
        try {
            b1f = float.Parse(b1.text) / 255f;
            b2f = float.Parse(b2.text) / 255f;
            b3f = float.Parse(b3.text) / 255f;
            r1f = float.Parse(r1.text) / 255f;
            r2f = float.Parse(r2.text) / 255f;
            r3f = float.Parse(r3.text) / 255f;
        } catch {
            print("Input Error");
        }
        this.background.color = new Color(b1f, b2f, b3f);
        this.GetComponent<Image>().color = new Color(r1f, r2f, r3f);
    }

    public void expand() {
        this.GetComponent<RectTransform>().localScale += new Vector3(2, 2, 0);
        changeDirection();
        scale += 1;
        scaleText.text = scale.ToString();
    }

    public void reduct() {
        this.GetComponent<RectTransform>().localScale -= new Vector3(2, 2, 0);
        changeDirection();
        scale -= 1;
        scaleText.text = scale.ToString();
    }

    public void changeDirection() {
        int rand = Random.Range(0, 8);
        this.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, rand * 45);
    }
}
