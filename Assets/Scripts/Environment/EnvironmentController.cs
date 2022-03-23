using UnityEngine;
using Random = UnityEngine.Random;

namespace Environment
{
    public class EnvironmentController : MonoBehaviour
    {
        [SerializeField] private EnvironmentModel model = new EnvironmentModel();
        private void Awake()
        {
            InitRoad();
        }
        private void InitRoad()
        {
            var index = Random.Range(0,model.roads.Count);
           Instantiate(model.roads[index],transform);
        }
    }
}
