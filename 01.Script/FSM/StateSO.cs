using YH.Animators;
using UnityEngine;

namespace YH.FSM
{
    [CreateAssetMenu(fileName = "StateSO", menuName = "SO/FSM/StateSO")]
    public class StateSO : ScriptableObject
    {
        public FSMState stateName;
        public string className;
        public AnimParamSO animParam;
    }
}
