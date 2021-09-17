using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyLandGame {
    public interface IMovementStationSwitcher {

        void SwitchState<T>() where T : BaseMovementState;

    }
}
