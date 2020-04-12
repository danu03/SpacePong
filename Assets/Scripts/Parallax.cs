using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = -1.0f;
    public GameObject PrefabBackground = null;
    public int OrderInLayer = 0;
    private Background firstBackground = new Background();
    private Background secondBackground = new Background();
    private float width;
    private float startPos;
    private float endPos;
    
    private struct Background
    {
        public GameObject sprite;
        public float percent;
    }
    // Start is called before the first frame update
    void Start()
    {
        firstBackground.sprite = Instantiate(PrefabBackground, this.transform);
        firstBackground.sprite.GetComponent<SpriteRenderer>().sortingOrder = OrderInLayer;
        firstBackground.percent = 0.5f;

        secondBackground.sprite = Instantiate(PrefabBackground, this.transform);
        secondBackground.sprite.GetComponent<SpriteRenderer>().sortingOrder = OrderInLayer;
        secondBackground.percent = 1.0f;

        width = firstBackground.sprite.GetComponent<SpriteRenderer>().bounds.size.x;
        startPos = width;
        endPos = -width;
    }

    void Update()
    {
        firstBackground.percent = Mathf.Repeat(firstBackground.percent - (speed * Time.deltaTime), 1.0f);
        float xPos1 = Mathf.Lerp(startPos, endPos, firstBackground.percent);
        firstBackground.sprite.transform.position = new Vector3(xPos1, 0, 0);

        secondBackground.percent = Mathf.Repeat(secondBackground.percent - (speed * Time.deltaTime), 1.0f);
        float xPos2 = Mathf.Lerp(startPos, endPos, secondBackground.percent);
        secondBackground.sprite.transform.position = new Vector3(xPos2, 0, 0);

    }

}
