// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatrixPropertyValueNumericalTypeEnum.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Enums
{
    public enum MatrixPropertyValueNumericalTypeEnum
    {
        NotDefined = 0, 

        // n1 = x
        NumericalEqual = 1,

        // n1 > x
        NumericalLower = 2,

        // n1 ≥ x
        NumericalLowerOrEqual = 3,

        // n1 < x
        NumericalUpper = 4,

        // n1 ≤ x
        NumericalUpperOrEqual = 5,

        // n1 < x < n2
        NumericalLimitedStrictly = 6,

        // n1 ≤ x ≤ n2
        NumericalLimitedEqual = 7,

        // n1 < x ≤ n2
        NumericalLimitedWithLowerEqual = 8,

        // n1 ≤ x < n2
        NumericalLimitedWithUpperEqual = 9
    }
}