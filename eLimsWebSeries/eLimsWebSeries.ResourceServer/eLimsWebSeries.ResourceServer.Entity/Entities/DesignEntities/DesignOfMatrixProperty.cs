// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixProperty.cs" company="Emergence-I">
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

    public sealed class DesignOfMatrixProperty : EntityBase, IEntityWithTranslations<DesignOfMatrixPropertyTranslation, DesignOfLanguage>
    {
        #region Constructor

        public DesignOfMatrixProperty()
        {
            this.Choices = new List<DesignOfMatrixPropertyChoice>();
            this.Translations = new List<DesignOfMatrixPropertyTranslation>();
            this.Trackings = new List<DesignOfMatrixPropertyTracking>();
        }

        #endregion

        #region Public Properties

        public string Code { get; set; }

        public string InternalComment { get; set; }

        public string InternalName { get; set; }

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

        public ICollection<DesignOfMatrixPropertyChoice> Choices { get; set; }

        public ICollection<DesignOfMatrixPropertyTracking> Trackings { get; set; }

        public ICollection<DesignOfMatrixPropertyTranslation> Translations { get; set; }

        #endregion
    }
}