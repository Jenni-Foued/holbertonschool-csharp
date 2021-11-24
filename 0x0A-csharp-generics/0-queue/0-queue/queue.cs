using System;

namespace _0_queue
{
    /// <summary>
    /// Declare the generic class
    /// </summary>
    class Queue<T>
    {
        /// <summary>
        /// Returns the Queue’s type
        /// </summary>
        public Type CheckType()
        {
            return typeof(T);
        }
    }
}
