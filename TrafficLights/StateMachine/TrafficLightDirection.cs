using System.Diagnostics.CodeAnalysis;

namespace TrafficLights.StateMachine
{
    /// <summary>
    /// Направление светофора.
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public enum TrafficLightDirection
    {
        /// <summary>
        /// Север
        /// </summary>
        North = 0,

        /// <summary>
        /// Юг
        /// </summary>
        South = 1,

        /// <summary>
        /// Запад
        /// </summary>
        West = 2,

        /// <summary>
        /// Восток
        /// </summary>
        East = 3,
    }
}