﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan _ceilingFan;
        CeilingFanSpeed _previousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }

        public void Undo()
        {
            switch (_previousSpeed)
            {
                case CeilingFanSpeed.Low:
                    _ceilingFan.Low();
                    break;
                case CeilingFanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;
                case CeilingFanSpeed.High:
                    _ceilingFan.High();
                    break;
                case CeilingFanSpeed.Off:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}
