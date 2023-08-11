using UnityEngine;
using UnityEngine.UI;

public class AudioVolumeControl : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    
    public Slider slider1;
    public Slider slider2;

    private void Start()
    {
        // Configura los valores iniciales de los sliders según el volumen actual de las fuentes de audio
        slider1.value = audioSource1.volume;
        slider2.value = audioSource2.volume;
        
        // Agrega los métodos de escucha para los eventos de cambio de valor en los sliders
        slider1.onValueChanged.AddListener(UpdateVolume1);
        slider2.onValueChanged.AddListener(UpdateVolume2);
    }

    private void UpdateVolume1(float value)
    {
        audioSource1.volume = value;
    }
    
    private void UpdateVolume2(float value)
    {
        audioSource2.volume = value;
    }
}
