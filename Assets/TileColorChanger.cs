using UnityEngine;

public class TileColorChanger : MonoBehaviour
{
    public LayerMask tileLayerMask; // Маска слоя тайлов

    private Color originalColor;
    private Renderer tileRenderer;

    void Start()
    {
        tileRenderer = GetComponent<Renderer>();
        originalColor = tileRenderer.material.color;
    }

    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, tileLayerMask))
            {
                // Если наведен на нужный тайл, меняем его цвет
                if (hit.collider.gameObject == gameObject)
                {
                    tileRenderer.material.color = Color.red; // Здесь можно указать желаемый цвет
                }
            }
        
    }

    void OnMouseExit()
    {
        tileRenderer.material.color = originalColor;
    }
}