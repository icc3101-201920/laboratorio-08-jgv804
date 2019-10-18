using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_7_OOP_201902.Interfaces
{
    public interface IAttackPoints
    {
        int[] GetAttackPoints(EnumType line = EnumType.None);
    }
}
