using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   [Tooltip("Using this variable, you can set any maximum value of the found objects")]
   [SerializeField] private int _maxFinds = 10;
   [SerializeField] private AudioSource _audio;
   [SerializeField] private GameObject _overPanel;

   private int _cerrentFind;

   public void Finds()
   {
      _cerrentFind++;
      _audio.Play();
   }

   private void FixedUpdate()
   {
      if (_cerrentFind >= _maxFinds)
      {
         _overPanel.SetActive(true);
      } 
   }

   public void Restart()
   {
      SceneManager.LoadScene(0);
   }
}
