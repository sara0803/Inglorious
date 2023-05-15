using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickOn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] private AudioClip _compressClip, _uncompressClip;
    [SerializeField] private AudioSource _source;    
   
    public void OnPointerDown(PointerEventData eventData)
    {
        _image.sprite = _pressed;
        _source.PlayOneShot(_compressClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.sprite = _default;
        _source.PlayOneShot(_uncompressClip);
    }

    public void IWasClicked()
    {
        Debug.Log("Clicked!!");
        
    }

    
}
