using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robko01Lib.Controllers.ORLIN369
{
    /// <summary>
    /// Functional codes.
    /// </summary>
    enum FunctionCodes : byte
    {
        /// <summary>
        /// Ping device.
        /// </summary>
        Ping = 1,

        /// <summary>
        /// Stop engines.
        /// </summary>
	    Stop,

        /// <summary>
        /// Disable engines.
        /// </summary>
        Disable,

        /// <summary>
        /// Enable engines.
        /// </summary>
        Enable,

        /// <summary>
        /// Clear robot position.
        /// </summary>
        Clear,

        /// <summary>
        /// Move to relative position.
        /// </summary>
        MoveRelative,

        /// <summary>
        /// Move to absolute position.
        /// </summary>
        MoveAblolute,

        /// <summary>
        /// Set digital port A value.
        /// </summary>
        DO,

        /// <summary>
        /// Read digital port A value. 
        /// </summary>
        DI,

        /// <summary>
        /// Is robot is moveing?
        /// </summary>
        IsMoving,

        /// <summary>
        /// Current robot position.
        /// </summary>
        CurrentPosition,

        /// <summary>
        /// Move robot by speed parameter only.
        /// </summary>
        MoveSpeed
    }
}
