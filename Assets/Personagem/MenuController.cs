using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public string proximaFase;
    public GameObject[] itensMenu;
    public GameObject[] itensConfig;
    public void StartGame()
    {
        SceneManager.LoadScene(proximaFase);
    }

    public void Configuracoes()
    {
        for ( int i = 0; i < itensMenu.Length ; i++)
        {
            itensMenu[i].SetActive(false);
        }
        for ( int i = 0; i < itensConfig.Length; i++)
        {
            itensConfig[i].SetActive(true);
        }

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    //Configurações
    public void SairConfiguracoes()
    {
        for (int i = 0; i < itensConfig.Length; i++)
        {
            itensConfig[i].SetActive(false);
        }
        for (int i = 0; i < itensMenu.Length; i++)
        {
            itensMenu[i].SetActive(true);
        }

    }
    
    public void QualidadeBaixa()
    {
        QualitySettings.SetQualityLevel(0, true); 

    }
    public void QualidadeMedia()
    {
        QualitySettings.SetQualityLevel(1, true);

    }
    public void QualidadeAlta()
    {
        QualitySettings.SetQualityLevel(2, true);

    }
}
