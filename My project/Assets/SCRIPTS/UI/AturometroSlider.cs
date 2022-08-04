using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AturometroSlider : MonoBehaviour
{
    public float vida, porcentagem;
    public Slider slider;
    int max = 10;
    [SerializeField]
    float progresso;
    private void Start()
    {
        vida = max;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vida -= 1;
        }
        progresso = (float) vida / max;
        //Debug.Log("progresso: " + progresso);
        slider.value = progresso;

        if (progresso > 50)
        {
            //print("verde");
        }
        else if (progresso > 25)
        {
            //print("amarelo");
        }
        else
        {
            //print("vermelho");
        }

        if (vida <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
}
