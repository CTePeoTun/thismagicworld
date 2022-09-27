using UnityEngine;
using UnityEngine.EventSystems;

namespace TMW
{
    public class Hexagon : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Selected", this.gameObject);
        }

    }
}