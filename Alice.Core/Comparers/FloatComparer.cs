using System.Collections.Generic;

namespace Alice.Comparers
{
    public class FloatComparer : IComparer<float>
    {

        #region Свойства

        public float Epsilon { get; set; }

        #endregion

        #region Реализация интерфейса IComparer<float>

        public int Compare(float x, float y)
        {
            if (x > y + Epsilon)
                return 1;
            if (x < y - Epsilon)
                return -1;
            return 0;
        }

        #endregion

    }
}
