using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	public float count;
	public void OnPointerDown(PointerEventData eventData) {
		count++;
	}
	public void OnPointerUp(PointerEventData eventData) {
		count--;
	}
}