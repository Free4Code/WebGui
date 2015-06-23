// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrix.cs" company="Emergence-I">
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

    public sealed class DeliveredMatrix : DeliveredEntityBase, IEntityWithTranslations<DeliveredMatrixTranslation, DeliveredLanguage>
    {
        #region Constructor

        public DeliveredMatrix()
        {
            this.MatrixPropertyValues = new List<DeliveredMatrixPropertyValue>();
            this.Translations = new List<DeliveredMatrixTranslation>();
            this.Trackings = new List<DeliveredMatrixTracking>();
        }

        #endregion

        #region Public Properties

        public string Code { get; set; }

        public string Hierarchy { get; set; } // AAA00;AAA01...

        public string Type
        {
            get
            {
                return this.TypeEnum.ToString();
            }

            set
            {
                this.TypeEnum = (MatrixTypeEnum)Enum.Parse(typeof(MatrixTypeEnum), value);
            }
        }

        public MatrixTypeEnum TypeEnum { get; set; }

        public string InternalName { get; set; }

        public string InternalComment { get; set; }
        
        #endregion

        #region Linked Properties

        public Guid? ParentId { get; set; }

        public DeliveredMatrix Parent { get; set; }

        public ICollection<DeliveredMatrixPropertyValue> MatrixPropertyValues { get; set; }

        public ICollection<DeliveredMatrixTracking> Trackings { get; set; }

        public ICollection<DeliveredMatrixTranslation> Translations { get; set; }

        #endregion
    }
}
