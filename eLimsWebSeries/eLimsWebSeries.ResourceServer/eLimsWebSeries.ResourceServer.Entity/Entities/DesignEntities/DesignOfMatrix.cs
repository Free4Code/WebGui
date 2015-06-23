// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrix.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Enums;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DesignOfMatrix : EntityBase, IEntityWithTranslations<DesignOfMatrixTranslation, DesignOfLanguage>
    {
        #region Constructor

        public DesignOfMatrix()
        {
            this.MatrixPropertyValues = new List<DesignOfMatrixPropertyValue>();
            this.Translations = new List<DesignOfMatrixTranslation>();
            this.Trackings = new List<DesignOfMatrixTracking>();
        }

        #endregion

        #region Public Properties

        public string Code { get; set; }

        // AAA00;AAA01...
        public string Hierarchy { get; set; }

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
        
        public string State
        {
            get
            {
                return this.StateEnum.ToString();
            }

            set
            {
                this.StateEnum = (StateEnum)Enum.Parse(typeof(StateEnum), value);
            }
        }

        public StateEnum StateEnum { get; set; }
        
        public string InternalName { get; set; }

        public string InternalComment { get; set; }

        #endregion

        #region Linked Properties

        public Guid? ParentId { get; set; }

        public DesignOfMatrix Parent { get; set; }

        public ICollection<DesignOfMatrixPropertyValue> MatrixPropertyValues { get; set; }

        public ICollection<DesignOfMatrixTracking> Trackings { get; set; }

        public ICollection<DesignOfMatrixTranslation> Translations { get; set; }

        #endregion
    }
}
