using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveformgenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Texture2D _texture2D;
    [SerializeField] private RawImage _image;
    void Start()
    {
        _texture2D = PaintWaveformSpectrum(_audioClip, 1, 100, 2, Color.blue);
        GetComponent<Image> ().overrideSprite = Sprite.Create (_texture2D, new Rect (0f, 0f, _texture2D.width, _texture2D.height), new Vector2 (0.5f, 0.5f));
        
    }

    [SerializeField] private AudioClip _audioClip;

    public Texture2D PaintWaveformSpectrum(AudioClip audio, float saturation, int width, int height, Color col) {
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGBA32, false);
        float[] samples = new float[audio.samples];
        float[] waveform = new float[width];
        audio.GetData(samples, 0);
        int packSize = ( audio.samples / width ) + 1;
        int s = 0;
        for (int i = 0; i < audio.samples; i += packSize) {
            waveform[s] = Mathf.Abs(samples[i]);
            s++;
        }
 
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                tex.SetPixel(x, y, Color.black);
            }
        }
 
        for (int x = 0; x < waveform.Length; x++) {
            for (int y = 0; y <= waveform[x] * ((float)height * .75f); y++) {
                tex.SetPixel(x, ( height / 2 ) + y, col);
                tex.SetPixel(x, ( height / 2 ) - y, col);
            }
        }
        tex.Apply();
        //GetComponent<Image> ().overrideSprite = Sprite.Create (_texture2D, new Rect (0f, 0f, _texture2D.width, _texture2D.height), new Vector2 (0.5f, 0.5f));

        _image.texture = tex;
        return tex;
    }
}
