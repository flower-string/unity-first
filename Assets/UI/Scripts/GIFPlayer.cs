using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GIFPlayer : MonoBehaviour { 

    public string gifFilePath;
    public float frameDelay = 0.1f;

    private Texture2D gifTexture;
    private Texture2D[] frames;
    private int currentFrame = 0;

    void Start () {
        byte[] fileData = System.IO.File.ReadAllBytes(gifFilePath);
        gifTexture = new Texture2D(2, 2);
        gifTexture.LoadImage(fileData);

        frames = new Texture2D[gifTexture.width / (gifTexture.width / 5)];

        for (int i = 0; i < gifTexture.width; i += gifTexture.width / 5) {
            Texture2D frame = new Texture2D(gifTexture.width / 5, gifTexture.height);
            frame.SetPixels(gifTexture.GetPixels(i, 0, gifTexture.width / 5, gifTexture.height));
            frame.Apply();
            frames[i / (gifTexture.width / 5)] = frame;
        }

        StartCoroutine(PlayGIF());
    }

    IEnumerator PlayGIF () {
        while (true) {
            GetComponent<RawImage>().texture = frames[currentFrame];
            yield return new WaitForSeconds(frameDelay);
            currentFrame = (currentFrame + 1) % frames.Length;
        }
    }

}