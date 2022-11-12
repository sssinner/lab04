
using System.Diagnostics;


namespace FirstTask
{
    public abstract class AttributeManager
    {
        public virtual void Show(params object[] values)
        {
            foreach (object type in values)
            {
                Debug.Print($"{type.GetType()} - {type}");
            }
        }
    }
}