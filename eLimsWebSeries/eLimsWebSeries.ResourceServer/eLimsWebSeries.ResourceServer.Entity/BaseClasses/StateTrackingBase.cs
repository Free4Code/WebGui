// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateTrackingBase.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.BaseClasses
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.Enums;

    public abstract class StateTrackingBase : EntityBase
    {
        #region Public Properties

        public string Context { get; set; }

        public string StartingState
        {
            get
            {
                return this.StartingStateEnum.ToString();
            }

            set
            {
                this.StartingStateEnum = (StateEnum)Enum.Parse(typeof(StateEnum), value);
            }
        }

        public StateEnum StartingStateEnum { get; set; }

        public string ActionName { get; set; }

        public DateTime ActionDate { get; set; }

        public string ActionUser { get; set; }

        public string EndingState
        {
            get
            {
                return this.EndingStateEnum.ToString();
            }

            set
            {
                this.EndingStateEnum = (StateEnum)Enum.Parse(typeof(StateEnum), value);
            }
        }

        public StateEnum EndingStateEnum { get; set; }

        #endregion
    }
}