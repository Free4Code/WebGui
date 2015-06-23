// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyValue.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Enums;

    public sealed class DeliveredMatrixPropertyValue : DeliveredEntityBase
    {
        #region Public Properties

        public MatrixPropertyValueNumericalTypeEnum NumericalTypeEnum { get; set; }

        public string NumericalType
        {
            get
            {
                return this.NumericalTypeEnum.ToString();
            }

            set
            {
                this.NumericalTypeEnum = (MatrixPropertyValueNumericalTypeEnum)Enum.Parse(typeof(MatrixPropertyValueNumericalTypeEnum), value);
            }
        }

        public string Value
        {
            get
            {
                switch (this.MatrixProperty.TypeEnum)
                {
                    case MatrixPropertyTypeEnum.Bool:
                        return this.BoolValue.ToString();
                    case MatrixPropertyTypeEnum.Choice:
                        return this.MatrixPropertyChoice.InternalName;
                    case MatrixPropertyTypeEnum.Numerical:
                        switch (this.NumericalTypeEnum)
                        {
                            case MatrixPropertyValueNumericalTypeEnum.NotDefined:
                                return null;
                            case MatrixPropertyValueNumericalTypeEnum.NumericalEqual:
                                return string.Format("{0} = x", this.DoubleValue1);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLower:
                                return string.Format("{0} > x", this.DoubleValue1);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLowerOrEqual:
                                return string.Format("{0} ≥ x", this.DoubleValue1);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalUpper:
                                return string.Format("{0} < x", this.DoubleValue1);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalUpperOrEqual:
                                return string.Format("{0} ≤ x", this.DoubleValue1);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLimitedStrictly:
                                return string.Format("{0} < x < {1}", this.DoubleValue1, this.DoubleValue2);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLimitedEqual:
                                return string.Format("{0} ≤ x ≤ {1}", this.DoubleValue1, this.DoubleValue2);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLimitedWithLowerEqual:
                                return string.Format("{0} < x ≤ {1}", this.DoubleValue1, this.DoubleValue2);
                            case MatrixPropertyValueNumericalTypeEnum.NumericalLimitedWithUpperEqual:
                                return string.Format("{0} ≤ x < {1}", this.DoubleValue1, this.DoubleValue2);
                            default:
                                return null;
                        }

                    default:
                        return null;
                }
            }
        }

        public bool? BoolValue { get; set; }

        public double? DoubleValue1 { get; set; }

        public double? DoubleValue2 { get; set; }

        #endregion

        #region Linked Properties

        public Guid MatrixId { get; set; }

        public DeliveredMatrix Matrix { get; set; }

        public Guid MatrixPropertyId { get; set; }

        public DeliveredMatrixProperty MatrixProperty { get; set; }

        public Guid? MatrixPropertyChoiceId { get; set; }

        public DeliveredMatrixPropertyChoice MatrixPropertyChoice { get; set; }

        #endregion
    }
}
