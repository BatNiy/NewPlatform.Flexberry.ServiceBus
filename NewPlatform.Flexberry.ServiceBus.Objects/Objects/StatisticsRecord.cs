﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// StatisticsRecord.
    /// </summary>
    // *** Start programmer edit section *** (StatisticsRecord CustomAttributes)

    // *** End programmer edit section *** (StatisticsRecord CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("CompressView", new string[] {
            "Since",
            "To",
            "StatisticsInterval",
            "SentCount",
            "ReceivedCount",
            "ErrorsCount",
            "UniqueErrorsCount",
            "ConnectionCount",
            "QueueLength",
            "SentAvgTime",
            "QueryAvgTime",
            "StatisticsSetting"})]
    [View("DetailView", new string[] {
            "Since as \'Start interval\'",
            "To as \'End interval\'",
            "StatisticsInterval as \'Interval\'",
            "SentCount as \'Messages sent\'",
            "ReceivedCount as \'Messages received\'",
            "ErrorsCount as \'Errors (including repeated)\'",
            "UniqueErrorsCount as \'Unique errors (without repeated)\'",
            "StatisticsSetting"}, Hidden=new string[] {
            "StatisticsSetting"})]
    [View("EditView", new string[] {
            "StatisticsSetting as \'Statistics setting\'",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name",
            "Since as \'Start interval\'",
            "To as \'End interval\'",
            "StatisticsInterval as \'Interval\'",
            "SentCount as \'Messages sent\'",
            "ReceivedCount as \'Messages received\'",
            "ErrorsCount as \'Errors (including repeated)\'",
            "UniqueErrorsCount as \'Unique errors (without repeated)\'",
            "ConnectionCount as \'Outgoing connections\'",
            "QueueLength as \'Queue at end of interval\'",
            "SentAvgTime as \'Sent average time\'",
            "QueryAvgTime as \'Query average time\'"}, Hidden=new string[] {
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name"})]
    [MasterViewDefineAttribute("EditView", "StatisticsSetting", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Subscription.Description")]
    [View("ListView", new string[] {
            "StatisticsSetting",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description as \'Statistics setting\'",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name",
            "Since as \'Start interval\'",
            "To as \'End interval\'",
            "StatisticsInterval as \'Interval\'",
            "SentCount as \'Messages sent\'",
            "ReceivedCount as \'Messages received\'",
            "ErrorsCount as \'Errors (including repeated)\'",
            "UniqueErrorsCount as \'Unique errors (without repeated)\'"}, Hidden=new string[] {
            "StatisticsSetting",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name"})]
    public class StatisticsRecord : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fSince;
        
        private System.DateTime fTo;
        
        private NewPlatform.Flexberry.ServiceBus.StatisticsInterval fStatisticsInterval;
        
        private int fSentCount;
        
        private int fReceivedCount;
        
        private int fErrorsCount;
        
        private int fUniqueErrorsCount;
        
        private int fConnectionCount;
        
        private int fQueueLength;
        
        private int fSentAvgTime;
        
        private int fQueryAvgTime;
        
        private NewPlatform.Flexberry.ServiceBus.StatisticsSetting fStatisticsSetting;
        
        // *** Start programmer edit section *** (StatisticsRecord CustomMembers)
        private int sentCount = 0;
        private int sentSumTime = 0;
        private int queryCount = 0;
        private int querySumTime = 0;
        // *** End programmer edit section *** (StatisticsRecord CustomMembers)

        
        /// <summary>
        /// Since.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.Since CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.Since CustomAttributes)
        [NotNull()]
        public virtual System.DateTime Since
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.Since Get start)

                // *** End programmer edit section *** (StatisticsRecord.Since Get start)
                System.DateTime result = this.fSince;
                // *** Start programmer edit section *** (StatisticsRecord.Since Get end)

                // *** End programmer edit section *** (StatisticsRecord.Since Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.Since Set start)

                // *** End programmer edit section *** (StatisticsRecord.Since Set start)
                this.fSince = value;
                // *** Start programmer edit section *** (StatisticsRecord.Since Set end)

                // *** End programmer edit section *** (StatisticsRecord.Since Set end)
            }
        }
        
        /// <summary>
        /// To.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.To CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.To CustomAttributes)
        [NotNull()]
        public virtual System.DateTime To
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.To Get start)

                // *** End programmer edit section *** (StatisticsRecord.To Get start)
                System.DateTime result = this.fTo;
                // *** Start programmer edit section *** (StatisticsRecord.To Get end)

                // *** End programmer edit section *** (StatisticsRecord.To Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.To Set start)

                // *** End programmer edit section *** (StatisticsRecord.To Set start)
                this.fTo = value;
                // *** Start programmer edit section *** (StatisticsRecord.To Set end)

                // *** End programmer edit section *** (StatisticsRecord.To Set end)
            }
        }
        
        /// <summary>
        /// StatisticsInterval.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.StatisticsInterval CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.StatisticsInterval CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.StatisticsInterval StatisticsInterval
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsInterval Get start)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsInterval Get start)
                NewPlatform.Flexberry.ServiceBus.StatisticsInterval result = this.fStatisticsInterval;
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsInterval Get end)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsInterval Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsInterval Set start)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsInterval Set start)
                this.fStatisticsInterval = value;
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsInterval Set end)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsInterval Set end)
            }
        }
        
        /// <summary>
        /// SentCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.SentCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.SentCount CustomAttributes)
        public virtual int SentCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.SentCount Get start)

                // *** End programmer edit section *** (StatisticsRecord.SentCount Get start)
                int result = this.fSentCount;
                // *** Start programmer edit section *** (StatisticsRecord.SentCount Get end)

                // *** End programmer edit section *** (StatisticsRecord.SentCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.SentCount Set start)

                // *** End programmer edit section *** (StatisticsRecord.SentCount Set start)
                this.fSentCount = value;
                // *** Start programmer edit section *** (StatisticsRecord.SentCount Set end)

                // *** End programmer edit section *** (StatisticsRecord.SentCount Set end)
            }
        }
        
        /// <summary>
        /// ReceivedCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.ReceivedCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.ReceivedCount CustomAttributes)
        public virtual int ReceivedCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.ReceivedCount Get start)

                // *** End programmer edit section *** (StatisticsRecord.ReceivedCount Get start)
                int result = this.fReceivedCount;
                // *** Start programmer edit section *** (StatisticsRecord.ReceivedCount Get end)

                // *** End programmer edit section *** (StatisticsRecord.ReceivedCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.ReceivedCount Set start)

                // *** End programmer edit section *** (StatisticsRecord.ReceivedCount Set start)
                this.fReceivedCount = value;
                // *** Start programmer edit section *** (StatisticsRecord.ReceivedCount Set end)

                // *** End programmer edit section *** (StatisticsRecord.ReceivedCount Set end)
            }
        }
        
        /// <summary>
        /// ErrorsCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.ErrorsCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.ErrorsCount CustomAttributes)
        public virtual int ErrorsCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.ErrorsCount Get start)

                // *** End programmer edit section *** (StatisticsRecord.ErrorsCount Get start)
                int result = this.fErrorsCount;
                // *** Start programmer edit section *** (StatisticsRecord.ErrorsCount Get end)

                // *** End programmer edit section *** (StatisticsRecord.ErrorsCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.ErrorsCount Set start)

                // *** End programmer edit section *** (StatisticsRecord.ErrorsCount Set start)
                this.fErrorsCount = value;
                // *** Start programmer edit section *** (StatisticsRecord.ErrorsCount Set end)

                // *** End programmer edit section *** (StatisticsRecord.ErrorsCount Set end)
            }
        }
        
        /// <summary>
        /// UniqueErrorsCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.UniqueErrorsCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.UniqueErrorsCount CustomAttributes)
        public virtual int UniqueErrorsCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.UniqueErrorsCount Get start)

                // *** End programmer edit section *** (StatisticsRecord.UniqueErrorsCount Get start)
                int result = this.fUniqueErrorsCount;
                // *** Start programmer edit section *** (StatisticsRecord.UniqueErrorsCount Get end)

                // *** End programmer edit section *** (StatisticsRecord.UniqueErrorsCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.UniqueErrorsCount Set start)

                // *** End programmer edit section *** (StatisticsRecord.UniqueErrorsCount Set start)
                this.fUniqueErrorsCount = value;
                // *** Start programmer edit section *** (StatisticsRecord.UniqueErrorsCount Set end)

                // *** End programmer edit section *** (StatisticsRecord.UniqueErrorsCount Set end)
            }
        }
        
        /// <summary>
        /// ConnectionCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.ConnectionCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.ConnectionCount CustomAttributes)
        public virtual int ConnectionCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.ConnectionCount Get start)

                // *** End programmer edit section *** (StatisticsRecord.ConnectionCount Get start)
                int result = this.fConnectionCount;
                // *** Start programmer edit section *** (StatisticsRecord.ConnectionCount Get end)

                // *** End programmer edit section *** (StatisticsRecord.ConnectionCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.ConnectionCount Set start)

                // *** End programmer edit section *** (StatisticsRecord.ConnectionCount Set start)
                this.fConnectionCount = value;
                // *** Start programmer edit section *** (StatisticsRecord.ConnectionCount Set end)

                // *** End programmer edit section *** (StatisticsRecord.ConnectionCount Set end)
            }
        }
        
        /// <summary>
        /// QueueLength.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.QueueLength CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.QueueLength CustomAttributes)
        public virtual int QueueLength
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.QueueLength Get start)

                // *** End programmer edit section *** (StatisticsRecord.QueueLength Get start)
                int result = this.fQueueLength;
                // *** Start programmer edit section *** (StatisticsRecord.QueueLength Get end)

                // *** End programmer edit section *** (StatisticsRecord.QueueLength Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.QueueLength Set start)

                // *** End programmer edit section *** (StatisticsRecord.QueueLength Set start)
                this.fQueueLength = value;
                // *** Start programmer edit section *** (StatisticsRecord.QueueLength Set end)

                // *** End programmer edit section *** (StatisticsRecord.QueueLength Set end)
            }
        }
        
        /// <summary>
        /// SentAvgTime.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.SentAvgTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.SentAvgTime CustomAttributes)
        public virtual int SentAvgTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.SentAvgTime Get start)

                // *** End programmer edit section *** (StatisticsRecord.SentAvgTime Get start)
                int result = this.fSentAvgTime;
                // *** Start programmer edit section *** (StatisticsRecord.SentAvgTime Get end)
                if (sentSumTime > 0 && sentCount > 0)
                    result = sentSumTime / sentCount;
                // *** End programmer edit section *** (StatisticsRecord.SentAvgTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.SentAvgTime Set start)
                sentCount++;
                sentSumTime += value;
                // *** End programmer edit section *** (StatisticsRecord.SentAvgTime Set start)
                this.fSentAvgTime = value;
                // *** Start programmer edit section *** (StatisticsRecord.SentAvgTime Set end)

                // *** End programmer edit section *** (StatisticsRecord.SentAvgTime Set end)
            }
        }
        
        /// <summary>
        /// QueryAvgTime.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.QueryAvgTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.QueryAvgTime CustomAttributes)
        public virtual int QueryAvgTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.QueryAvgTime Get start)

                // *** End programmer edit section *** (StatisticsRecord.QueryAvgTime Get start)
                int result = this.fQueryAvgTime;
                // *** Start programmer edit section *** (StatisticsRecord.QueryAvgTime Get end)
                if (querySumTime > 0 && queryCount > 0)
                    result = querySumTime / queryCount;
                // *** End programmer edit section *** (StatisticsRecord.QueryAvgTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.QueryAvgTime Set start)
                queryCount++;
                querySumTime += value;
                // *** End programmer edit section *** (StatisticsRecord.QueryAvgTime Set start)
                this.fQueryAvgTime = value;
                // *** Start programmer edit section *** (StatisticsRecord.QueryAvgTime Set end)

                // *** End programmer edit section *** (StatisticsRecord.QueryAvgTime Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ServiceBus.StatisticsSetting.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsRecord.StatisticsSetting CustomAttributes)

        // *** End programmer edit section *** (StatisticsRecord.StatisticsSetting CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "StatisticsSetting"})]
        public virtual NewPlatform.Flexberry.ServiceBus.StatisticsSetting StatisticsSetting
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsSetting Get start)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsSetting Get start)
                NewPlatform.Flexberry.ServiceBus.StatisticsSetting result = this.fStatisticsSetting;
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsSetting Get end)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsSetting Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsSetting Set start)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsSetting Set start)
                this.fStatisticsSetting = value;
                // *** Start programmer edit section *** (StatisticsRecord.StatisticsSetting Set end)

                // *** End programmer edit section *** (StatisticsRecord.StatisticsSetting Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CompressView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CompressView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CompressView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsRecord));
                }
            }
            
            /// <summary>
            /// "DetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsRecord));
                }
            }
            
            /// <summary>
            /// "EditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EditView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsRecord));
                }
            }
            
            /// <summary>
            /// "ListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ListView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsRecord));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of StatisticsRecord.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfStatisticsRecord CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfStatisticsRecord CustomAttributes)
    public class DetailArrayOfStatisticsRecord : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfStatisticsRecord members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfStatisticsRecord members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type StatisticsRecord by index.
        /// </summary>
        /// <summary>
        /// Adds object with type StatisticsRecord.
        /// </summary>
        public DetailArrayOfStatisticsRecord(NewPlatform.Flexberry.ServiceBus.StatisticsSetting fStatisticsSetting) : 
                base(typeof(StatisticsRecord), ((ICSSoft.STORMNET.DataObject)(fStatisticsSetting)))
        {
        }
        
        public NewPlatform.Flexberry.ServiceBus.StatisticsRecord this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ServiceBus.StatisticsRecord)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ServiceBus.StatisticsRecord dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}