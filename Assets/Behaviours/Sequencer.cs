using UnityEngine;

namespace Behaviours {

public class Sequencer : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(0.0f, 0.1f, 0.0f);
  }
}

}