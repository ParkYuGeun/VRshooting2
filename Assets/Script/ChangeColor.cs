using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void ChangeRenderColor()
    {
        var render = GetComponent<Renderer>();
        render.material.color = Random.ColorHSV();
    }
}
