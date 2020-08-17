namespace Robko01Lib.Data
{
    /// <summary>
    /// Hold joint names.
    /// </summary>
    public enum JointName : int
    {
        /// <summary>
        /// All the axises.
        /// </summary>
        All = -1,

        /// <summary>
        /// Base
        /// </summary>
        Base = 0,

        /// <summary>
        /// Shoulder
        /// </summary>
        Shoulder = 1,

        /// <summary>
        /// Elbow
        /// </summary>
        Elbow = 2,

        /// <summary>
        /// Left fifferent.
        /// </summary>
        LD = 3,

        /// <summary>
        /// Right different.
        /// </summary>
        RD = 4,

        /// <summary>
        /// Gripper of the robot.
        /// </summary>
        Gripper = 5,

        /// <summary>
        /// Pitch
        /// </summary>
        Pitch = 6,

        /// <summary>
        /// Roll
        /// </summary>
        Roll = 7
    }
}
