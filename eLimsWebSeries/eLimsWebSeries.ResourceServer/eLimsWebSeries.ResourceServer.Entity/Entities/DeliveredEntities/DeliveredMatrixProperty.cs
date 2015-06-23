// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixProperty.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Enums;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DeliveredMatrixProperty : DeliveredEntityBase, IEntityWithTranslations<DeliveredMatrixPropertyTranslation, DeliveredLanguage>
    {
        #region Constructor

        public DeliveredMatrixProperty()
        {
            this.Choices = new List<DeliveredMatrixPropertyChoice>();
            this.Translations = new List<DeliveredMatrixPropertyTranslation>();
            this.Trackings = new List<DeliveredMatrixPropertyTracking>();
        }

        #endregion

        #region Public Properties

        public string Code { get; set; }

        public string InternalComment { get; set; }

        public string InternalName { get; set; }

        public string Type
        {
            get
            {
                return this.TypeEnum.ToString();
            }

            set
            {
                this.TypeEnum = (MatrixPropertyTypeEnum)Enum.Parse(typeof(MatrixPropertyTypeEnum), value);
            }
        }

        public MatrixPropertyTypeEnum TypeEnum { get; set; }

        #endregion

        #region Linked Properties

        public ICollection<DeliveredMatrixPropertyChoice> Choices { get; set; }

        public ICollection<DeliveredMatrixPropertyTracking> Trackings { get; set; }

        public ICollection<DeliveredMatrixPropertyTranslation> Translations { get; set; }

        #endregion
    }
}