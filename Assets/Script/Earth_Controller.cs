using UnityEngine;
using TMPro;

public class Earth_Controller : MonoBehaviour
{
    float points = 0f;
    float rotationSpeed = 0f;
    float targetSpeed = 100f; 

    public RectTransform earthTrasnform;
    public TMP_Text poinView;

    void Update()
    {
        addPoint();
        rotateEarth();
    }

    public void addPoint()
    {
        bool click = Input.GetMouseButtonDown(0);
        bool space = Input.GetKeyDown(KeyCode.Space);

        if (click || space)
        {
            points++;
            poinView.text = points.ToString();

            rotationSpeed = targetSpeed;
        }
    }

    public void rotateEarth()
    {
        rotationSpeed = Mathf.Lerp(rotationSpeed, 0f, Time.deltaTime);

        earthTrasnform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}